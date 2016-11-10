using UnityEngine;
using System.Collections;
using System;

namespace uFlex
{
    //[Serializable]
    //public struct FlexSpring
    //{
    //    public int idA;
    //    public int idB;
    //    public float restLength;
    //    public float stiffness;
    //}

    public class FlexSprings : MonoBehaviour
    {
        //[HideInInspector]
        public int m_springsCount;

    //    public FlexSpring[] m_springs;

        [HideInInspector]
        public int[] m_springIndices;

        [HideInInspector]
        public float[] m_springCoefficients; 

        [HideInInspector]
        public float[] m_springRestLengths;

        public int m_springsIndex = -1;

        public bool m_overrideStiffness = false;

        public float m_newStiffness = 1.0f;

        void Awake()
        {

        }

        // Use this for initialization
        void Start()
        {
            if (m_overrideStiffness)
                OverrideStiffness();
        }

        // Update is called once per frame
        void Update()
        {
            if (m_overrideStiffness)
                OverrideStiffness();
        }

        private void OverrideStiffness()
        {
            for (int i = 0; i < m_springsCount; i++)
            {
                m_springCoefficients[i] = m_newStiffness;
            }
        }

        public virtual void OnDrawGizmosSelected()
        {

            //Gizmos.color = m_color;
            //Gizmos.DrawWireCube(m_bounds.center + transform.position, m_bounds.size);

            //if (this.m_particles != null && m_drawDebug)
            //{

            //    for (int i = 0; i < m_particlesCount; i++)
            //    {
            //        Gizmos.color = m_colours[i];
            //        if (!Application.isPlaying)
            //            Gizmos.DrawSphere(transform.TransformPoint(m_particles[i]), 0.5f);
            //        else
            //            Gizmos.DrawSphere(m_particles[i], 0.5f);
            //    }
            //}


        }
    }
}