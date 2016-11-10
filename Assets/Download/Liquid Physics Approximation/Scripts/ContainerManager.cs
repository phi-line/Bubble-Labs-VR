using UnityEngine;
//using UnityEditor;
using System;
using System.Collections;
using System.Collections.Generic;

[ExecuteInEditMode]
[DisallowMultipleComponent]
[RequireComponent (typeof (MeshFilter))]
[RequireComponent (typeof (MeshRenderer))]
[RequireComponent (typeof (SphereCollider))]

public class ContainerManager : MonoBehaviour {
    public WandController wandController;
    private Vector2 currentAxis;

	public bool UsePhysicsAnimation = true;
	public bool UseStaticAnimation;

	[Serializable] public class LiquidBehaviorClass {
		[Range(0, 4)] public float Amount = .5f;

		public Vector3 Pivot = new Vector3(0, 0, 0);

		[Serializable] public class OnPhysicsAnimationClass {
			[Range(1, 5)] public float Density = 5;
			[Range(.1f, 10)] public float Weight = 5;
		}
		public OnPhysicsAnimationClass OnPhysicsAnimation;

		[Serializable] public class OnStaticAnimationClass {
			[Range(.1f, 10)] public float SliceDensity = .7f;
			[Range(.1f, .5f)] public float SliceHeight = .2f;
            [Range(.1f, 10)] public float SliceSpeed = .3f;
		}
		public OnStaticAnimationClass OnStaticAnimation;

		[Serializable] public class BubblesClass {
			public bool Add = false;

			[Range(1, 5)] public int MeshAmount = 1;
		}
		public BubblesClass Bubbles;
	}
	public LiquidBehaviorClass LiquidBehavior;

	[Serializable] public class ColorsClass {
		[Serializable] public class GlassClass {
			public Color Color = new Color(1, 1, 1, 1);
			[Range(.5f, 5)] public float FresnelOpacity = 1.5f;
			[Range(.1f, 1)] public float Reflectivity = .5f;
		}
		public GlassClass Glass;

		[Serializable] public class LiquidClass {
			public Color Color = new Color(1, 1, 1, 1);
			public bool EnableCustomTopColor;
			public Color TopColor = new Color(.7f, .7f, .7f, 1);
		}
		public LiquidClass Liquid;

		public Color Bubbles = new Color(1, 1, 1, 1);
	}
	public ColorsClass Colors;

	[Serializable] public class PatternsClass {
		[Serializable] public class GlassMainClass {
			public Texture2D Pattern;
			public int Tiling = 1;
		}
		public GlassMainClass GlassMain;

		[Serializable] public class GlassTranslucencyClass {
			public bool AddTranslucency;
			public Texture2D Pattern;
			public int Tiling = 1;
			[Range(0, 1)] public float SpeedX = .1f;
			[Range(0, 1)] public float SpeedY = .1f;
		}
		public GlassTranslucencyClass GlassTranslucency;

		[Serializable] public class LiquidClass {
			public Texture2D Gradient;
			public Texture2D StaticAnimationSlicePattern;
		}
		public LiquidClass Liquid;

		[Serializable] public class LiquidBubblesClass {
			public Texture2D Pattern;
			public int Tiling;
			[Range(.1f, 10)] public float Speed = .1f;
		}
		public LiquidBubblesClass LiquidBubbles;
	}
	public PatternsClass Patterns;

	private GameObject[] BubblesObjs;
	private Material BubblesObjMaterial;
	private bool SwitchStateDisableFlag;
	private Material[] ContainerMaterials = new Material[3];
	private Vector3 PreviousVelocity;
	private Vector3 Velocity;
	private float RotationDirX;
	private float RotationDirZ;
	private Vector3 PreviousObjPos;
	private float LocalTimeX;
	private float LocalTimeZ;
	private float InitReposDirX;
	private float InitReposDirZ;
	private float X;
	private float Z;
	
	void OnEnable () {
		//Define lenght of bubbles mesh array
		BubblesObjs = new GameObject[5];

		//Generate container materials
		if (!ContainerMaterials [0])
			ContainerMaterials [0] = new Material (Shader.Find ("Liquid Physics Approximation/Liquid"));
		if (!ContainerMaterials [1])
			ContainerMaterials [1] = new Material (Shader.Find ("Liquid Physics Approximation/Back glass"));
		if (!ContainerMaterials [2])
			ContainerMaterials [2] = new Material (Shader.Find ("Liquid Physics Approximation/Front glass"));

		GetComponent<MeshRenderer> ().sharedMaterials = ContainerMaterials;

		//Generate material for bubbles emission gameobject
		if (!BubblesObjMaterial)
			BubblesObjMaterial = new Material (Shader.Find ("Liquid Physics Approximation/Liquid bubbles"));

		//Search trace of required objects for effect, and fill the relative variables if these are already existing on the current Editor instance
		GameObject[] ChildrensObj = new GameObject[transform.GetComponentsInChildren<Transform> ().Length];

		for (int i = 0; i < 2; i++)
			for (int j = 0; j < ChildrensObj.Length; j++) {
				if (i == 0)
					if (transform.GetComponentsInChildren<Transform> () [j].name.Contains ("BubblesObj"))
						ChildrensObj[j] = transform.GetComponentsInChildren<Transform> () [j].gameObject;
				if (i == 1)
					#if UNITY_EDITOR
						DestroyImmediate (ChildrensObj[j]);
					#else
						Destroy(ChildrensObj[j]);
					#endif
			}

		//#if UNITY_EDITOR
		//	//Enable editor update on a specific function
		//	EditorApplication.update = null;
		//	if (!EditorApplication.isPlaying)
		//		EditorApplication.update = EditorUpdate;
		//#endif
	}

	void EditorUpdate () {
		try {
			LiquidMove ();
		} catch {}
	}

    void Start() {
    }

    void Update() {
        currentAxis = wandController.triggerAxis;
        LiquidBehavior.OnStaticAnimation.SliceSpeed = (float)Math.Round(currentAxis.x, 1) * 3.0f;
        LiquidBehavior.OnStaticAnimation.SliceHeight = currentAxis.x / 2.0f;
    }


	void FixedUpdate () {
        LiquidMove ();
	}

	void LiquidMove () {
		if (!SwitchStateDisableFlag) {
			if (!UseStaticAnimation) {
				UseStaticAnimation = false;

				UsePhysicsAnimation = true;
			} else {
				UseStaticAnimation = true;

				UsePhysicsAnimation = false;

				SwitchStateDisableFlag = true;
			}
		} else {
			if (!UsePhysicsAnimation) {
				UsePhysicsAnimation = false;

				UseStaticAnimation = true;
			} else {
				UsePhysicsAnimation = true;

				UseStaticAnimation = false;

				SwitchStateDisableFlag = false;
			}
		}

		if (Patterns.GlassMain.Tiling < 1)
			Patterns.GlassMain.Tiling = 1;
		if (Patterns.GlassTranslucency.Tiling < 1)
			Patterns.GlassTranslucency.Tiling = 1;
		if (Patterns.LiquidBubbles.Tiling < 1)
			Patterns.LiquidBubbles.Tiling = 1;

		//Generate gameobject for bubbles emission
		for (int i = 0; i < BubblesObjs.Length; i++) {
			if (i < LiquidBehavior.Bubbles.MeshAmount) {
				if (!BubblesObjs [i]) {
					BubblesObjs [i] = new GameObject (transform.name + " BubblesObj" + i);

					BubblesObjs [i].AddComponent<MeshFilter> ();
					BubblesObjs [i].AddComponent<MeshRenderer> ();

					BubblesObjs [i].GetComponent<MeshFilter> ().sharedMesh = GetComponent<MeshFilter> ().sharedMesh;
					BubblesObjs [i].GetComponent<MeshRenderer> ().sharedMaterial = BubblesObjMaterial;

					BubblesObjs [i].transform.position = transform.position;
					BubblesObjs [i].transform.parent = transform;

					if (i == 0) {
						BubblesObjs [i].transform.eulerAngles = new Vector3 (0, 0, 0);

						BubblesObjs [i].transform.localScale = new Vector3 (.95f, .95f, .95f);
					}
					if (i == 1) {
						BubblesObjs [i].transform.eulerAngles = new Vector3 (0, 30, 0);

						BubblesObjs [i].transform.localScale = new Vector3 (.75f, .95f, .75f);
					}
					if (i == 2) {
						BubblesObjs [i].transform.eulerAngles = new Vector3 (0, 60, 0);

						BubblesObjs [i].transform.localScale = new Vector3 (.55f, .95f, .55f);
					}
					if (i == 3) {
						BubblesObjs [i].transform.eulerAngles = new Vector3 (0, 90, 0);

						BubblesObjs [i].transform.localScale = new Vector3 (.35f, .95f, .35f);
					}
					if (i == 4) {
						BubblesObjs [i].transform.eulerAngles = new Vector3 (0, 120, 0);

						BubblesObjs [i].transform.localScale = new Vector3 (.15f, .95f, .15f);
					}
				} else {
					BubblesObjs [i].GetComponent<MeshFilter> ().sharedMesh = GetComponent<MeshFilter> ().sharedMesh;

					BubblesObjs [i].GetComponent<MeshRenderer> ().enabled = LiquidBehavior.Bubbles.Add;
				}
			} else {
				if (BubblesObjs [i])
					#if UNITY_EDITOR
						DestroyImmediate (BubblesObjs [i]);
					#else
						Destroy(BubblesObjs [i]);
					#endif
			}
		}

		//Liquid direction math
		if (LiquidBehavior.Amount > 0 && LiquidBehavior.Amount < 1 && !UseStaticAnimation) {
			Vector3 VelocityMath = (transform.position - PreviousVelocity) / Time.deltaTime;

			Velocity = new Vector3(VelocityMath.x, VelocityMath.y, VelocityMath.z);
			PreviousVelocity = transform.position;

			float MaxVelocity = .7f;
			float LiquidDensityMultiplicator = 10f;

			if (Mathf.Abs (Velocity.x) > MaxVelocity) {
				RotationDirX = Mathf.Lerp (RotationDirX, (Velocity.x / LiquidBehavior.OnPhysicsAnimation.Density) / 2, 5 * Time.deltaTime);

				InitReposDirX = 0;

				LocalTimeX = Time.time;
			} else {
				if (Mathf.Abs (Velocity.z) < MaxVelocity) {
					X = (Time.time - LocalTimeX) * LiquidBehavior.OnPhysicsAnimation.Weight;

					if (RotationDirX != 0 && InitReposDirX == 0)
						InitReposDirX = RotationDirX > 0 ? -1 : 1;

					if (LocalTimeX > 0) {
						if (X > LiquidBehavior.OnPhysicsAnimation.Weight * LiquidDensityMultiplicator)
							RotationDirX = Mathf.Lerp (RotationDirX, 0, LiquidBehavior.OnPhysicsAnimation.Weight * Time.deltaTime);
						else
							RotationDirX = Mathf.Lerp (RotationDirX, ((Mathf.Sin (X * 2) / (X * 2 + .1f)) / 2) * InitReposDirX, LiquidBehavior.OnPhysicsAnimation.Weight * Time.deltaTime);
					}
				}
			}
			if (Mathf.Abs (Velocity.z) > MaxVelocity) {
				RotationDirZ = Mathf.Lerp (RotationDirZ, (Velocity.z / LiquidBehavior.OnPhysicsAnimation.Density) / 2, 5 * Time.deltaTime);

				InitReposDirZ = 0;

				LocalTimeZ = Time.time;
			} else {
				if (Mathf.Abs (Velocity.x) < MaxVelocity) {
					Z = (Time.time - LocalTimeZ) * LiquidBehavior.OnPhysicsAnimation.Weight;

					if (RotationDirZ != 0 && InitReposDirZ == 0)
						InitReposDirZ = RotationDirZ > 0 ? -1 : 1;

					if (LocalTimeZ > 0) {
						if (Z > LiquidBehavior.OnPhysicsAnimation.Weight * LiquidDensityMultiplicator)
							RotationDirZ = Mathf.Lerp (RotationDirZ, 0, LiquidBehavior.OnPhysicsAnimation.Weight * Time.deltaTime);
						else
							RotationDirZ = Mathf.Lerp (RotationDirZ, ((Mathf.Sin (Z * 2) / (Z * 2 + .1f)) / 2) * InitReposDirZ, LiquidBehavior.OnPhysicsAnimation.Weight * Time.deltaTime);
					}
				}
			}
		} else {
			RotationDirX = Mathf.MoveTowards (RotationDirX, 0, 5 * Time.deltaTime);
			RotationDirZ = Mathf.MoveTowards (RotationDirZ, 0, 5 * Time.deltaTime);
		}

		//Set shaders properties
		for (int i = 0; i < 3; i++) {
			if (i == 0) {
				ContainerMaterials [i].SetColor ("_Color", Colors.Liquid.Color);
				ContainerMaterials [i].SetInt ("_EnableCustomTopColor", !Colors.Liquid.EnableCustomTopColor ? 0 : 1);
				ContainerMaterials [i].SetColor ("_TopColor", Colors.Liquid.TopColor);

				float LessOffsetRecalc = -.5f * (transform.localScale.y - 1);

				ContainerMaterials [i].SetVector ("_Pivot", LiquidBehavior.Pivot);
				ContainerMaterials [i].SetFloat ("_RotationX", RotationDirX);
				ContainerMaterials [i].SetFloat ("_RotationZ", RotationDirZ);

				ContainerMaterials [i].SetFloat ("_Amount", Mathf.Lerp (LessOffsetRecalc, transform.localScale.y + LessOffsetRecalc, LiquidBehavior.Amount));

				for(int j = 0; j < LiquidBehavior.Bubbles.MeshAmount; j++) {
					BubblesObjs [j].GetComponent<MeshRenderer> ().sharedMaterial.SetVector ("_Pivot", LiquidBehavior.Pivot);
					BubblesObjs [j].GetComponent<MeshRenderer> ().sharedMaterial.SetFloat ("_RotationX", RotationDirX);
					BubblesObjs [j].GetComponent<MeshRenderer> ().sharedMaterial.SetFloat ("_RotationZ", RotationDirZ);

					BubblesObjs [j].GetComponent<MeshRenderer> ().sharedMaterial.SetFloat ("_Amount", Mathf.Lerp (LessOffsetRecalc, transform.localScale.y + LessOffsetRecalc, LiquidBehavior.Amount));

					BubblesObjs [j].GetComponent<MeshRenderer> ().sharedMaterial.SetTexture ("_Pattern", Patterns.LiquidBubbles.Pattern);
					BubblesObjs [j].GetComponent<MeshRenderer> ().sharedMaterial.SetColor ("_PatternColor", Colors.Bubbles);
					BubblesObjs [j].GetComponent<MeshRenderer> ().sharedMaterial.SetInt ("_PatternTiling", Patterns.LiquidBubbles.Tiling);
					BubblesObjs [j].GetComponent<MeshRenderer> ().sharedMaterial.SetFloat ("_PatternSpeed", Patterns.LiquidBubbles.Speed);
				}

				ContainerMaterials [i].SetFloat ("_EnableStaticAnimation", UseStaticAnimation ? 1 : 0);
				ContainerMaterials [i].SetFloat ("_StaticAnimationSliceDensity", LiquidBehavior.OnStaticAnimation.SliceDensity);
				ContainerMaterials [i].SetFloat ("_StaticAnimationSliceHeight", LiquidBehavior.OnStaticAnimation.SliceHeight);
				ContainerMaterials [i].SetFloat ("_StaticAnimationSliceSpeed", LiquidBehavior.OnStaticAnimation.SliceSpeed);

				ContainerMaterials [i].SetTexture ("_Gradient", Patterns.Liquid.Gradient);
				ContainerMaterials [i].SetTexture ("_StaticAnimationSlicePattern", Patterns.Liquid.StaticAnimationSlicePattern);
			} else {
                ContainerMaterials[i].SetColor("_Color", Colors.Glass.Color);
                ContainerMaterials [i].SetFloat ("_FresnelOpacity", Colors.Glass.FresnelOpacity);
				ContainerMaterials [i].SetInt ("_AddedFresnel", !Patterns.GlassMain.Pattern ? 0 : 1);

				ContainerMaterials [i].SetTexture ("_MainPattern", Patterns.GlassMain.Pattern);
				ContainerMaterials [i].SetInt ("_MainPatternTiling", Patterns.GlassMain.Tiling);

				ContainerMaterials [i].SetInt ("_AddTranslucency", Patterns.GlassTranslucency.AddTranslucency ? 1 : 0);
				ContainerMaterials [i].SetTexture ("_TranslucencyPattern", Patterns.GlassTranslucency.Pattern);
				ContainerMaterials [i].SetInt ("_TranslucencyPatternTiling", Patterns.GlassTranslucency.Tiling);
				ContainerMaterials [i].SetFloat ("_TranslucencyPatternSpeedX", Patterns.GlassTranslucency.SpeedX);
				ContainerMaterials [i].SetFloat ("_TranslucencyPatternSpeedY", Patterns.GlassTranslucency.SpeedY);

				ContainerMaterials [i].SetFloat ("_Reflectivity", Colors.Glass.Reflectivity);
			}
		}
	}
}