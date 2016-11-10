Shader "Custom/ColorWheel"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
		_Red("Red", Float) = 0
		_Green("Green", Float) = 0
		_Blue("Blue", Float) = 0
	}
	SubShader
	{
		// No culling or depth
		Cull Off ZWrite Off ZTest Always
		Blend SrcAlpha OneMinusSrcAlpha

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);
				o.uv = v.uv;
				return o;
			}
			
			sampler2D _MainTex;
			Float _Red;
			Float _Green;
			Float _Blue;

			fixed4 frag (v2f i) : SV_Target
			{
				fixed4 col = tex2D(_MainTex, i.uv);
				//fixed4 col = fixed4(i.uv.x, _Value, i.uv.y, 1);
				if ((i.uv.x - .5) * (i.uv.x - .5) + (i.uv.y - .5) * (i.uv.y - .5) > .5 * .5)
					{
					//col.a = 0;
					}

				// just invert the colors
				//col = 1 - col;
				return col;
			}
			ENDCG
		}
	}
}

//vert shader - defines geometry
//frag sahder - color per pixel
