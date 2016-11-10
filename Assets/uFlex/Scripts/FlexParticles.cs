﻿using UnityEngine;
using System.Collections;
using System;

namespace uFlex
{
    [Serializable]
    public struct Particle
    {
        public Vector3 pos;
        public float invMass;
    }

    public enum FlexInteractionType
    {
        None = 0,
        SelfCollideAll = Flex.Phase.eFlexPhaseSelfCollide,
        SelfCollideFiltered = Flex.Phase.eFlexPhaseSelfCollide | Flex.Phase.eFlexPhaseSelfCollideFilter,
        Fluid = Flex.Phase.eFlexPhaseSelfCollide | Flex.Phase.eFlexPhaseFluid,
    }

    public enum FlexBodyType
    {
        Rigid,
        Soft,
        Cloth,
        Inflatable,
        Fluid,
        Rope,
        Tearable,
        Other
    }

    public class FlexParticles : MonoBehaviour
    {
        public bool m_initialized = false;

        public int m_instanceId = -1;

        public FlexBodyType m_type;

        public int m_collisionGroup = -1;

        //    public Flex.Phase m_phase = 0;
        public FlexInteractionType m_interactionType = FlexInteractionType.None;
        public bool m_overrideMass = false;
        public float m_mass = 1;

        //public Color m_color = Color.gray;

        public int m_particlesCount;              //!< Number of particles

        public int m_particlesIndex = -1;

        [HideInInspector]
        public Particle[] m_particles;              //!< Local space particle positions, x,y,z,1/mass

        [HideInInspector]
        public Color[] m_colours;                   //!< Particle colour for quick preview

        [HideInInspector]
        public float[] m_densities;

        [HideInInspector]
        public Vector3[] m_velocities;

        [HideInInspector]
        public bool[] m_particlesActivity;

        public Color m_colour;

        public Vector3 m_initialVelocity;

        public bool m_drawDebug = false;

        [HideInInspector]
        public Bounds m_bounds; //!< Approximate bounds for quick preview in the editor

        public int m_activeCount = 0;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            m_activeCount = 0;
            for (int i = 0; i < m_particlesCount; i++)
            {
                if (m_particlesActivity[i])
                    m_activeCount++;

            }
        }

        public virtual void OnDrawGizmos()
        {

            Gizmos.color = m_colour;
            Gizmos.DrawWireCube(m_bounds.center + transform.position, m_bounds.size);

            if (m_particles != null && m_drawDebug)
            {

                for (int i = 0; i < m_particlesCount; i++)
                {
                    Gizmos.color = m_colours[i];
                    if (!Application.isPlaying)
                        Gizmos.DrawSphere(transform.TransformPoint(m_particles[i].pos), 0.5f);
                    else
                        Gizmos.DrawSphere(m_particles[i].pos, 0.5f);
                }
            }


        }
    }
}