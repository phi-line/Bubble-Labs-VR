using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;


namespace uFlex

{
    /// <summary>
    /// Emits fluids from FlexParticles
    /// </summary>
    public class FlexEmitter : FlexProcessor
    {
        //private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
        //private Valve.VR.EVRButtonId touchButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad;

        //public SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
        //public SteamVR_TrackedObject trackedObj;

        //refs
        public Renderer rend;
        public WandController wandController;
        public HapticsManager hapticsManager;
        public SoundManager soundManager;
        public FlexParticles m_particles;

        //sound
        //public AudioClip[] clips;
        public List<AudioClip> clips = new List<AudioClip>();

        //prefs -
        public bool m_alwaysOn = false;
        public int m_id = 0;
        public int m_rate = 10;
        public float m_speed = 0;
        public float m_radius = 1.0f;
        public bool m_loop = true;
        public Color m_color = Color.white;

        //privates
        private Vector2 currentTriggerAxis;
        //private float timer;
        //public float timeThreshold;

        void Start()
        {
            foreach (AudioClip a in Resources.LoadAll("Audio/Bubbles", typeof(AudioClip)))
            {
                //Debug.Log("Clip found: " + a.name);
                clips.Add(a);
            }

            //trackedObj = GetComponent<SteamVR_TrackedObject>();

            rend = GetComponent<Renderer>();

            if (m_particles == null)
                m_particles = GetComponent<FlexParticles>();
        }

        public override void PreContainerUpdate(FlexSolver solver, FlexContainer cntr, FlexParameters parameters)
        {
            //if (controller == null)
            //{
            //    Debug.Log("Controller not initialized");
            //    return;
            //}

            //if (controller.GetPressDown(touchButton))
            //{
            //    m_color = new Color(Random.value, Random.value, Random.value, 1);
            //    rend.material.color =  m_color;
            //}

            Vector3 vel = transform.forward * m_speed;
            Vector3 pos = transform.position;

            currentTriggerAxis = wandController.triggerAxis;
            //timer -= Time.deltaTime / 10;
            //timeThreshold = 1f - currentTriggerAxis.x;

            if (currentTriggerAxis.x > 0.05f || m_alwaysOn)
            {
                
                for (int i = m_id; i< m_id + m_rate && i < m_particles.m_particlesCount; i++)
                {

                    m_particles.m_particlesActivity[i] = true;
                    m_particles.m_particles[i].pos = pos + UnityEngine.Random.insideUnitSphere * m_radius;
                    m_particles.m_velocities[i] = vel * 2.0f * currentTriggerAxis.x; //controller.GetAxis(triggerButton).x;
                    m_particles.m_colours[i] = m_color;

                    //haptics and sound
                    if (i % (m_rate * Math.Round((currentTriggerAxis.x * 15.0f), MidpointRounding.AwayFromZero)) == 0)
                    { hapticsManager.GradientPulse(currentTriggerAxis.x); }
                    if (i % (m_rate * Math.Round((10.0f), MidpointRounding.AwayFromZero)) == 0)
                    { soundManager.PlayRand(clips); }
                }

                m_id += m_rate;

                if (m_loop && m_id > m_particles.m_particlesCount-1)
                    m_id = 0;
            }
        }

        //void OnGUI()
        //{
        //    GUI.color = Color.grey;
        //    GUI.Label(new Rect(10, 25, 200, 25), "Press right trigger to emit particles");
        //    GUI.Label(new Rect(10, 50, 200, 25), "Touchpad to change hue and brightness");
        //    GUI.Label(new Rect(10, 75, 200, 25), "Press menu for FPS debug");
        //}
    }
}