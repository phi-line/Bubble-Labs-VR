﻿using UnityEngine;
using System;
using System.Runtime.InteropServices;

namespace uFlex
{

    /// <summary>
    /// Wrapper around flex.h
    /// </summary>
    public class Flex
    {
        //[StructLayoutAttribute(LayoutKind.Sequential)]
        //public struct Solver
        //{
        //}

        /// <summary>
        /// Simulation parameters for a solver
        /// </summary>
        public enum FlexRelaxationMode
        {
            /// <summary>
            /// The relaxation factor is a fixed multiplier on each constraint's position delta.
            /// </summary>
            Global = 0,


            /// <summary>
            /// The relaxation factor is a fixed multiplier on each constraint's delta divided by the particle's constraint count, 
            /// convergence will be slower but more reliable.
            /// </summary>
            Local = 1,
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct Params
        {
            /// <summary>
            /// Number of solver iterations to perform per-substep.
            /// </summary>
            public int mNumIterations;


            /// <summary>
            /// Constant acceleration applied to all particles.
            /// </summary>
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.R4)]
            public float[] mGravity;

            /// <summary>
            /// The maximum interaction radius for particles.
            /// </summary>
            public float mRadius;

            /// <summary>
            /// The distance non-fluid particles attempt to maintain from each other, must be in the range (0, radius].
            /// </summary>
            public float mSolidRestDistance;

            /// <summary>
            /// The distance fluid particles are spaced at the rest density, must be in the range (0, radius], 
            /// for fluids this should generally be 50-70% of mRadius, for rigids this can simply be the same as the particle radius.
            /// </summary>
            public float mFluidRestDistance;

            /// <summary>
            /// Coefficient of friction used when colliding against shapes.
            /// </summary>
            public float mDynamicFriction;


            /// <summary>
            /// Coefficient of static friction used when colliding against shapes.
            /// </summary>
            public float mStaticFriction;


            /// <summary>
            /// Coefficient of friction used when colliding particles.
            /// </summary>
            public float mParticleFriction;


            /// <summary>
            /// Coefficient of restitution used when colliding against shapes, particle collisions are always inelastic.
            /// </summary>
            public float mRestitution;


            /// <summary>
            /// Controls how strongly particles stick to surfaces they hit, default 0.0, range [0.0, +inf].
            /// </summary>
            public float mAdhesion;


            /// <summary>
            /// Particles with a velocity magnitude smaller than this threshold will be considered fixed.
            /// </summary>
            public float mSleepThreshold;


            /// <summary>
            /// The magnitude of particle velocity will be clamped to this value at the end of each step.
            /// </summary>
            public float mMaxSpeed;


            /// <summary>
            /// Artificially decrease the mass of particles based on height from a fixed reference point, this makes stacks and piles converge faster.
            /// </summary>
            public float mShockPropagation;


            /// <summary>
            /// Damps particle velocity based on how many particle contacts it has.
            /// </summary>
            public float mDissipation;


            /// <summary>
            /// Viscous drag force, applies a force proportional, and opposite to the particle velocity.
            /// </summary>
            public float mDamping;


            /// <summary>
            /// Increase the amount of inertia in shape-matching clusters to improve stability.
            /// </summary>
            public float mInertiaBias;


            /// <summary>
            /// Constant acceleration applied to particles that belong to dynamic triangles, drag needs to be > 0 for wind to affect triangles.
            /// </summary>
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.R4)]
            public float[] mWind;


            /// <summary>
            /// Drag force applied to particles belonging to dynamic triangles, proportional to velocity^2*area in the negative velocity direction.
            /// </summary>
            public float mDrag;


            /// <summary>
            /// Lift force applied to particles belonging to dynamic triangles, 
            /// proportional to velocity^2*area in the direction perpendicular to velocity and (if possible), parallel to the plane normal.
            /// </summary>
            public float mLift;


            /// <summary>
            /// If true then particles with phase 0 are considered fluid particles and interact using the position based fluids method.
            /// </summary>
            [MarshalAsAttribute(UnmanagedType.I1)]
            public bool mFluid;


            /// <summary>
            /// Control how strongly particles hold each other together, default: 0.025, range [0.0, +inf].
            /// </summary>
            public float mCohesion;


            /// <summary>
            /// 	Controls how strongly particles attempt to minimize surface area, default: 0.0, range: [0.0, +inf].
            /// </summary>
            public float mSurfaceTension;


            /// <summary>
            /// Smoothes particle velocities using XSPH viscosity.
            /// </summary>
            public float mViscosity;


            /// <summary>
            /// Increases vorticity by applying rotational forces to particles.
            /// </summary>
            public float mVorticityConfinement;


            /// <summary>
            /// Control how much anisotropy is present in resulting ellipsoids for rendering, 
            /// if zero then anisotropy will not be calculated, see flexGetAnisotropy()
            /// </summary>
            public float mAnisotropyScale;


            /// <summary>
            /// Clamp the anisotropy scale to this fraction of the radius.
            /// </summary>
            public float mAnisotropyMin;


            /// <summary>
            /// Clamp the anisotropy scale to this fraction of the radius.
            /// </summary>
            public float mAnisotropyMax;


            /// <summary>
            /// Control the strength of Laplacian smoothing in particles for rendering, if zero then smoothed positions will not be calculated, see flexGetSmoothParticles()
            /// </summary>
            public float mSmoothing;


            /// <summary>
            /// Add pressure from solid surfaces to particles.
            /// </summary>
            public float mSolidPressure;


            /// <summary>
            /// Drag force applied to boundary fluid particles.
            /// </summary>
            public float mFreeSurfaceDrag;


            /// <summary>
            /// Gravity is scaled by this value for fluid particles.
            /// </summary>
            public float mBuoyancy;


            /// <summary>
            /// Particles with kinetic energy + divergence above this threshold will spawn new diffuse particles.
            /// </summary>
            public float mDiffuseThreshold;


            /// <summary>
            /// Scales force opposing gravity that diffuse particles receive.
            /// </summary>
            public float mDiffuseBuoyancy;


            /// <summary>
            /// Scales force diffuse particles receive in direction of neighbor fluid particles.
            /// </summary>
            public float mDiffuseDrag;


            /// <summary>
            /// The number of neighbors below which a diffuse particle is considered ballistic.
            /// </summary>
            public int mDiffuseBallistic;


            /// <summary>
            /// Diffuse particles will be sorted by depth along this axis if non-zero.
            /// </summary>
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.R4)]
            public float[] mDiffuseSortAxis;


            /// <summary>
            /// Time in seconds that a diffuse particle will live for after being spawned, 
            /// particles will be spawned with a random lifetime in the range [0, mDiffuseLifetime].
            /// </summary>
            public float mDiffuseLifetime;


            /// <summary>
            /// Particles belonging to rigid shapes that move with a position delta magnitude larger than threshold will be permanently deformed in the rest pose.
            /// </summary>
            public float mPlasticThreshold;


            /// <summary>
            /// Controls the rate at which particles in the rest pose are deformed for particles passing the deformation threshold.
            /// </summary>
            public float mPlasticCreep;


            /// <summary>
            /// Distance particles maintain against shapes, note that for robust collision against triangle meshes this distance should be greater than zero.
            /// </summary>
            public float mCollisionDistance;


            /// <summary>
            /// Increases the radius used during neighbor finding, this is useful if particles are expected to move significantly during a single step to ensure contacts aren't missed on subsequent iterations.
            /// </summary>
            public float mParticleCollisionMargin;


            /// <summary>
            /// Increases the radius used during contact finding against kinematic shapes.
            /// </summary>
            public float mShapeCollisionMargin;


            /// <summary>
            /// Collision planes in the form ax + by + cz + d = 0.
            ///  float[8][4]
            /// </summary>
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.R4)]
            public float[] mPlanes;


            /// <summary>
            /// Num collision planes.
            /// </summary>
            public int mNumPlanes;


            /// <summary>
            /// How the relaxation is applied inside the solver.
            /// </summary>
            public FlexRelaxationMode mRelaxationMode;


            /// <summary>
            /// Control the convergence rate of the parallel solver, default: 1, values greater than 1 may lead to instability.
            /// </summary>
            public float mRelaxationFactor;
        }



        /// <summary>
        /// Flags that control the a particle's behavior and grouping
        /// </summary>
        public enum Phase
        {
            /// <summary>
            /// Low 24 bits represent the particle group for controlling collisions.
            /// </summary>
            eFlexPhaseGroupMask = 0x00ffffff,

            /// <summary>
            /// If set this particle will interact with particles of the same group.
            /// </summary>
            eFlexPhaseSelfCollide = 1 << 24,

            /// <summary>
            /// If set this particle will ignore collisions with particles closer than the radius in the rest pose, 
            /// this flag should not be specified unless valid rest positions have been specified using flexSetRestParticles()
            /// </summary>
            eFlexPhaseSelfCollideFilter = 1 << 25,


            /// <summary>
            /// If set this particle will generate fluid density constraints for its overlapping neighbors.
            /// </summary>
            eFlexPhaseFluid = 1 << 26,

        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct Timers
        {
            public float mPredict;
            public float mCreateCellIndices;
            public float mSortCellIndices;
            public float mCreateGrid;
            public float mReorder;
            public float mCollideParticles;
            public float mCollideShapes;
            public float mCollideTriangles;
            public float mCollideFields;
            public float mCalculateDensity;
            public float mSolveDensities;
            public float mSolveVelocities;
            public float mSolveShapes;
            public float mSolveSprings;
            public float mSolveContacts;
            public float mSolveInflatables;
            public float mCalculateAnisotropy;
            public float mUpdateDiffuse;
            public float mUpdateTriangles;
            public float mUpdateNormals;
            public float mFinalize;
            public float mUpdateBounds;
            public float mTotal;
        }

        public enum Error
        {
            eFlexErrorNone = 0,
            eFlexErrorWrongVersion = 1,
            eFlexErrorInsufficientGPU = 2,
            eFlexErrorDriverFailure = 3,
        }

        public enum Memory
        {
            eFlexMemoryHost = 0,
            eFlexMemoryDevice = 1,
            eFlexMemoryHostAsync = 2,
            eFlexMemoryDeviceAsync = 3,
        }

        public enum SolverCallbackStage
        {
            eFlexStageIterationStart,
            eFlexStageIterationEnd,
            eFlexStageSubstepBegin,
            eFlexStageSubstepEnd,
            eFlexStageUpdateEnd,
            eFlexStageCount,
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct SolverCallbackParams
        {

            /// FlexSolver*
            public IntPtr mSolver;

            /// void*
            public IntPtr mUserData;

            /// float*
            public IntPtr mParticles;

            /// float*
            public IntPtr mVelocities;

            /// int*
            public IntPtr mPhases;

            /// int
            public int mNumActive;

            /// float
            public float mDt;

            /// int*
            public IntPtr mOriginalToSortedMap;

            /// int*
            public IntPtr mSortedToOriginalMap;
        }

        /// Return Type: void
        ///params: FlexSolverCallbackParams
        public delegate void SolverCallback_mFunction(SolverCallbackParams @params);

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct SolverCallback
        {
            public IntPtr mUserData;
            public SolverCallback_mFunction AnonymousMember1;
        }

        public enum ErrorSeverity
        {
            eFlexLogError = 0,
            eFlexLogInfo = 1,
            eFlexLogWarning = 2,
            eFlexLogDebug = 4,
            eFlexLogAll = -1,
        }


        public delegate void ErrorCallback(ErrorSeverity type, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string msg, [InAttribute()] [MarshalAsAttribute(UnmanagedType.LPStr)] string file, int line);

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct FlexTriangleMesh
        {
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct SDF
        {
        }

        [StructLayoutAttribute(LayoutKind.Sequential, Size = 16)]
        public struct CollisionSphere
        {
            public float mRadius;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, Size = 16)]
        public struct CollisionCapsule
        {
            public float mRadius;
            public float mHalfHeight;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, Size = 16)]
        public struct FlexCollisionPlane
        {

            /// float[4]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.R4)]
            public float[] mPlane;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, Size = 16)]
        public struct CollisionTriangleMesh
        {

            /// FlexTriangleMesh*
            public IntPtr mMesh;
            public float mScale;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, Size = 16)]
        public struct CollisionSDF
        {

            /// FlexSDF*
            public IntPtr mField;
            public float mScale;
        }

        //UNION
        [StructLayoutAttribute(LayoutKind.Explicit, Size = 16)]
        public struct CollisionGeometry
        {

            [FieldOffsetAttribute(0)]
            public CollisionSphere mSphere;

            [FieldOffsetAttribute(0)]
            public CollisionCapsule mCapsule;

            [FieldOffsetAttribute(0)]
            public FlexCollisionPlane mPlane;

            [FieldOffsetAttribute(0)]
            public CollisionTriangleMesh mTriMesh;

            [FieldOffsetAttribute(0)]
            public CollisionSDF mSDF;
        }

        public enum CollisionShapeType
        {
            eFlexShapeSphere = 0,
            eFlexShapeCapsule = 1,
            eFlexShapeConvexMesh = 2,
            eFlexShapeTriangleMesh = 3,
            eFlexShapeSDF = 4,
        }

        [Flags]
        public enum CollisionShapeFlags : int
        {

            /// eFlexShapeFlagTypeMask -> 0x7
            eFlexShapeFlagTypeMask = 7,

            /// eFlexShapeFlagDynamic -> 8
            eFlexShapeFlagDynamic = 8,

            /// eFlexShapeFlagTrigger -> 16
            eFlexShapeFlagTrigger = 16,

            /// eFlexShapeFlagReserved -> 0xffffff00
            eFlexShapeFlagReserved = -256,
        }

        /// <summary>
        /// Generate a bit set for the particle phase, the group should be an integer smaller than 2^24, 
        /// and the flags should be a combination of FlexPhase enum values
        /// </summary>
        /// <param name="group"></param>
        /// <param name="flags"></param>
        /// <returns></returns>
        public static int MakePhase(int group, int flags)
        {
            return (group & (int)Phase.eFlexPhaseGroupMask) | flags;
        }

        /// <summary>
        /// Initialize library, should be called before any other API function.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="errorFunc"></param>
        /// <param name="deviceIndex"></param>
        /// <returns></returns>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexInit")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexInit")]
        #endif
        public static extern Error Init(int version, ErrorCallback errorFunc, int deviceIndex);

        /// <summary>
        /// Shutdown library, users should manually destroy any previously created solvers to ensure memory is freed before calling this method. 
        /// If a new CUDA context was created during flexInit() then it will be destroyed.
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexShutdown")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexShutdown")]
        #endif
        public static extern void Shutdown();

        /// <summary>
        /// Get library version number
        /// </summary>
        /// <returns></returns>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetVersion")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetVersion")]
        #endif
        public static extern int GetVersion();

        /// <summary>
        /// Create a new particle solver
        /// </summary>
        /// <param name="maxParticles"></param>
        /// <param name="maxDiffuseParticles"></param>
        /// <param name="maxNeighborsPerParticle"></param>
        /// <returns></returns>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexCreateSolver")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexCreateSolver")]
        #endif
        public static extern IntPtr CreateSolver(int maxParticles, int maxDiffuseParticles, byte maxNeighborsPerParticle);


        /// <summary>
        /// Delete a particle solver
        /// </summary>
        /// <param name="s"></param>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexDestroySolver")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexDestroySolver")]
        #endif
        public static extern void DestroySolver(IntPtr s);


        /// <summary>
        /// Registers a callback for a solver stage, the callback will be invoked from the same thread that calls flexUpdateSolver()
        /// </summary>
        /// <param name="s"></param>
        /// <param name="function"></param>
        /// <param name="stage"></param>
        /// <returns></returns>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexRegisterSolverCallback")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexRegisterSolverCallback")]
        #endif
        public static extern SolverCallback RegisterSolverCallback(IntPtr solverPtr, SolverCallback function, SolverCallbackStage stage);


        /// <summary>
        /// Move particle solver forward in time
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dt"></param>
        /// <param name="substeps"></param>
        /// <param name="timers"></param>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexUpdateSolver")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexUpdateSolver")]
        #endif
        public static extern void UpdateSolver(IntPtr s, float dt, int substeps, ref Timers timers);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="parameters"></param>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetParams")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetParams")]
        #endif
        public static extern void SetParams(IntPtr s, ref Params parameters);

        /// <summary>
        /// Retrieve solver paramters, default values will be set at solver creation time
        /// </summary>
        /// <param name="s"></param>
        /// <param name="parameterss"></param>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetParams")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetParams")]
        #endif
        public static extern void GetParams(IntPtr s, ref Params parameterss);


        /// <summary>
        /// Set the active particles indices in the solver
        /// </summary>
        /// <param name="s"></param>
        /// <param name="indices"></param>
        /// <param name="n"></param>
        /// <param name="source"></param>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetActive")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetActive")]
        #endif
        public static extern void SetActive(IntPtr s, IntPtr indices, int n, Memory source);

        /// <summary>
        /// Set the active particles indices in the solver
        /// </summary>
        /// <param name="s"></param>
        /// <param name="indices"></param>
        /// <param name="n"></param>
        /// <param name="source"></param>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetActive")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetActive")]
        #endif
        public static extern void SetActive(IntPtr s, int[] indices, int n, Memory source);

        /// <summary>
        /// Return the active particle indices
        /// </summary>
        /// <param name="s"></param>
        /// <param name="indices"></param>
        /// <param name="target"></param>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetActive")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetActive")]
        #endif
        public static extern void GetActive(IntPtr s, IntPtr indices, Memory target);

        /// <summary>
        /// Return the active particle indices
        /// </summary>
        /// <param name="s"></param>
        /// <param name="indices"></param>
        /// <param name="target"></param>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetActive")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetActive")]
        #endif
        public static extern void GetActive(IntPtr s, int[] indices, Memory target);

        /// <summary>
        /// Return the number of active particles in the solver
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetActiveCount")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetActiveCount")]
        #endif
        public static extern int GetActiveCount(IntPtr s);


        /// <summary>
        /// Set the particles state of the solver, a particle consists of 4 floating point numbers, its x,y,z position followed by its inverse mass (1/m)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <param name="n"></param>
        /// <param name="source"></param>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetParticles")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetParticles")]
        #endif
        public static extern void SetParticles(IntPtr s, IntPtr p, int n, Memory source);

        /// <summary>
        /// Set the particles state of the solver, a particle consists of 4 floating point numbers, its x,y,z position followed by its inverse mass (1/m)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <param name="n"></param>
        /// <param name="source"></param>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetParticles")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetParticles")]
        #endif
        public static extern void SetParticles(IntPtr s, Vector4[] p, int n, Memory source);

        /// <summary>
        /// Get the particles state of the solver, a particle consists of 4 floating point numbers, its x,y,z position followed by its inverse mass (1/m)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <param name="n"></param>
        /// <param name="target"></param>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetParticles")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetParticles")]
        #endif
        public static extern void GetParticles(IntPtr s, IntPtr p, int n, Memory target);


        /// <summary>
        /// Get the particles state of the solver, a particle consists of 4 floating point numbers, its x,y,z position followed by its inverse mass (1/m)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <param name="n"></param>
        /// <param name="target"></param>

        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetParticles")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetParticles")]
        #endif
        public static extern void GetParticles(IntPtr s, Vector4[] p, int n, Memory target);


        /// <summary>
        /// Set the particle positions in their rest state, if FlexPhase::eFlexPhaseSelfCollideFilter is set on the particle's 
        /// phase attribute then particles that overlap in the rest state will not generate collisions with each other
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <param name="n"></param>
        /// <param name="source"></param>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetRestParticles")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetRestParticles")]
        #endif
        public static extern void SetRestParticles(IntPtr s, Vector4[] p, int n, Memory source);

        /// <summary>
        /// Set the particle positions in their rest state, if FlexPhase::eFlexPhaseSelfCollideFilter is set on the particle's 
        /// phase attribute then particles that overlap in the rest state will not generate collisions with each other
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <param name="n"></param>
        /// <param name="source"></param>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetRestParticles")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetRestParticles")]
        #endif
        public static extern void SetRestParticles(IntPtr s, IntPtr p, int n, Memory source);

        /// <summary>
        /// Get the Laplacian smoothed particle positions for rendering, see FlexParams::mSmoothing
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <param name="n"></param>
        /// <param name="target"></param>

        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetSmoothParticles")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetSmoothParticles")]
        #endif
        public static extern void GetSmoothParticles(IntPtr s, IntPtr p, int n, Memory target);

        /// <summary>
        /// Get the Laplacian smoothed particle positions for rendering, see FlexParams::mSmoothing
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetSmoothParticles")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetSmoothParticles")]
        #endif
        public static extern void GetSmoothParticles(IntPtr s, Vector4[] p, int n, Memory target);


        /// <summary>
        /// Set the particle velocities, each velocity is a 3-tuple of x,y,z floating point values
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetVelocities")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetVelocities")]
        #endif
        public static extern void SetVelocities(IntPtr s, IntPtr v, int n, Memory source);

        /// <summary>
        /// Set the particle velocities, each velocity is a 3-tuple of x,y,z floating point values
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetVelocities")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetVelocities")]
        #endif
        public static extern void SetVelocities(IntPtr s, Vector3[] velocities, int n, Memory source);

        /// <summary>
        /// Get the particle velocities, each velocity is a 3-tuple of x,y,z floating point values
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetVelocities")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetVelocities")]
        #endif
        public static extern void GetVelocities(IntPtr s, IntPtr v, int n, Memory target);

        /// <summary>
        /// Get the particle velocities, each velocity is a 3-tuple of x,y,z floating point values
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetVelocities")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetVelocities")]
        #endif
        public static extern void GetVelocities(IntPtr s, Vector3[] velocities, int n, Memory target);

        /// <summary>
        /// Set the particles phase id array, each particle has an associated phase id which controls how it interacts with other particles. Particles with phase 0 interact with all other phase types.
        /// Particles with a non-zero phase id only interact with particles whose phase differs from theirs.This is useful, for example, to stop particles belonging to a single rigid shape from interacting with each other.
        /// Phase 0 is used to indicate fluid particles when FlexParams::mFluid is set.
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetPhases")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetPhases")]
        #endif
        public static extern void SetPhases(IntPtr s, IntPtr phases, int n, Memory source);

        /// <summary>
        /// Set the particles phase id array, each particle has an associated phase id which controls how it interacts with other particles. Particles with phase 0 interact with all other phase types.
        /// Particles with a non-zero phase id only interact with particles whose phase differs from theirs.This is useful, for example, to stop particles belonging to a single rigid shape from interacting with each other.
        /// Phase 0 is used to indicate fluid particles when FlexParams::mFluid is set.
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetPhases")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetPhases")]
        #endif
        public static extern void SetPhases(IntPtr s, int[] phases, int n, Memory source);

        /// <summary>
        /// Get the particle phase ids
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetPhases")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetPhases")]
        #endif
        public static extern void GetPhases(IntPtr s, IntPtr phases, int n, Memory target);

        /// <summary>
        /// Get the particle phase ids
        /// </summary>

        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetPhases")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetPhases")]
        #endif
        public static extern void GetPhases(IntPtr s, int[] phases, int n, Memory target);

        /// <summary>
        /// Set distance constraints for the solver. Each distance constraint consists of two particle indices stored consecutively, a rest-length, and a stiffness value. 
        /// These are not springs in the traditional sense, but behave somewhat like a traditional spring when lowering the stiffness coefficient.
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetSprings")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetSprings")]
        #endif
        public static extern void SetSprings(IntPtr s, int[] indices, float[] restLengths, float[] stiffness, int numSprings, Memory source);

        /// <summary>
        /// Set distance constraints for the solver. Each distance constraint consists of two particle indices stored consecutively, a rest-length, and a stiffness value. 
        /// These are not springs in the traditional sense, but behave somewhat like a traditional spring when lowering the stiffness coefficient.
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetSprings")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetSprings")]
        #endif
        public static extern void SetSprings(IntPtr s, IntPtr indices, IntPtr restLengths, IntPtr stiffness, int numSprings, Memory source);

        /// <summary>
        /// Get the distance constraints from the solver
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetSprings")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetSprings")]
        #endif
        public static extern void GetSprings(IntPtr s, int[] indices, float[] restLengths, float[] stiffness, int numSprings, Memory target);

        /// <summary>
        /// Get the distance constraints from the solver
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetSprings")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetSprings")]
        #endif
        public static extern void GetSprings(IntPtr s, IntPtr indices, IntPtr restLengths, IntPtr stiffness, int numSprings, Memory target);

        /// <summary>
        /// Set rigid body constraints for the solver.
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetRigids")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetRigids")]
        #endif
        //public static extern void flexSetRigids(ref FlexSolver s, ref int offsets, ref int indices, ref float restPositions, ref float restNormals, ref float stiffness, ref float rotations, ref float translations, int numRigids, FlexMemory source);
        public static extern void SetRigids(IntPtr s, int[] offsets, int[] indices, Vector3[] restPositions, Vector4[] restNormals, float[] stiffness, Quaternion[] rotations, Vector3[] translations, int numRigids, Memory source);

        /// <summary>
        /// Set per-particle normals to the solver, these will be overwritten after each simulation step, but can be used to initialize the normals to valid values
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetNormals")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetNormals")]
        #endif
        public static extern void SetNormals(IntPtr s, IntPtr normals, int n, Memory source);

        /// <summary>
        /// Set per-particle normals to the solver, these will be overwritten after each simulation step, but can be used to initialize the normals to valid values
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetNormals")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetNormals")]
        #endif
        public static extern void SetNormals(IntPtr s, Vector4[] normals, int n, Memory source);

        /// <summary>
        /// Get per-particle normals from the solver, these are the world-space normals computed during surface tension, cloth, and rigid body calculations
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetNormals")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetNormals")]
        #endif
        public static extern void GetNormals(IntPtr s, IntPtr normals, int n, Memory target);

        /// <summary>
        /// Get per-particle normals from the solver, these are the world-space normals computed during surface tension, cloth, and rigid body calculations
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetNormals")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetNormals")]
        #endif
        public static extern void GetNormals(IntPtr s, Vector4[] normals, int n, Memory target);

        /// <summary>
        /// 
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetRigidTransforms")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetRigidTransforms")]
        #endif
        public static extern void GetRigidTransforms(IntPtr s, Quaternion[] rotations, Vector3[] translations, Memory target);

        /// <summary>
        /// Get the rotation matrices for the rigid bodies in the solver
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetRigidTransforms")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetRigidTransforms")]
        #endif
        public static extern void GetRigidTransforms(IntPtr s, IntPtr rotations, IntPtr translations, Memory target);

        /// <summary>
        /// Create triangle mesh geometry, note that meshes may be used by multiple solvers if desired
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexCreateTriangleMesh")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexCreateTriangleMesh")]
        #endif
        public static extern IntPtr CreateTriangleMesh();

        /// <summary>
        /// Destroy a triangle mesh created with flexCreateTriangleMesh()
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexDestroyTriangleMesh")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexDestroyTriangleMesh")]
        #endif
        public static extern void DestroyTriangleMesh(IntPtr mesh);

        /// <summary>
        /// Specifies the triangle mesh geometry (vertices and indices), 
        /// this method will cause any internal data structures (e.g.: bounding volume hierarchies) to be rebuilt.
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexUpdateTriangleMesh")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexUpdateTriangleMesh")]
        #endif
        public static extern void UpdateTriangleMesh(IntPtr mesh, Vector3[] vertices, int[] indices, int numVertices, int numTriangles, Vector3 lower, Vector3 upper, Memory source);

        /// <summary>
        /// Retrive the local space bounds of the mesh, these are the same values specified to flexUpdateTriangleMesh()
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetTriangleMeshBounds")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetTriangleMeshBounds")]
        #endif
        public static extern void GetTriangleMeshBounds(IntPtr mesh, ref Vector3 lower, ref Vector3 upper);

        /// <summary>
        /// Set the signed distance field collision shapes, see FlexSDF for details.
        /// </summary>
        /// Return Type: FlexSDF*
        [DllImportAttribute("flexRelease_x64", EntryPoint = "flexCreateSDF")]
        public static extern IntPtr CreateSDF();

        /// <summary>
        /// Destroy a signed distance field
        /// </summary>
        /// Return Type: void
        ///sdf: FlexSDF*
        [DllImportAttribute("flexRelease_x64", EntryPoint = "flexDestroySDF")]
        public static extern void DestroySDF(IntPtr sdf);

        /// <summary>
        /// Update the signed distance field volume data, this method will upload the field data to a 3D texture on the GPU
        /// </summary>
        /// Return Type: void
        ///sdf: FlexSDF*
        ///dimx: int
        ///dimy: int
        ///dimz: int
        ///field: float*
        ///source: FlexMemory
        [DllImportAttribute("flexRelease_x64", EntryPoint = "flexUpdateSDF")]
        public static extern void UpdateSDF(ref SDF sdf, int dimx, int dimy, int dimz, ref float field, Memory source);

        /// <summary>
        /// Combines geometry type and static dynamic
        /// </summary>
        /// Return Type: int
        ///type: FlexCollisionShapeType
        ///dynamic: boolean
        //    [DllImportAttribute("flexRelease_x64", EntryPoint = "flexMakeShapeFlags")]
        //  public static extern int flexMakeShapeFlags(FlexCollisionShapeType type, [MarshalAsAttribute(UnmanagedType.I1)] bool dynamic);
        public static int MakeShapeFlags(CollisionShapeType type, bool dynamic)
        {
            return (int)type | (int)(dynamic ? CollisionShapeFlags.eFlexShapeFlagDynamic : 0);
        }


        /// <summary>
        /// DEPRECATED
        /// </summary>
        /// Return Type: void
        ///s: FlexSolver*
        ///shapes: FlexSDF*
        ///numShapes: int
        [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetFields")]
        public static extern void SetFields(IntPtr solverPtr, ref SDF shapes, int numShapes);

        /// <summary>
        /// Set the collision shapes for the solver
        /// </summary>
        /// Return Type: void
        ///s: FlexSolver*
        ///geometry: FlexCollisionGeometry*
        ///numGeometryEntries: int
        ///shapeAabbMins: float*
        ///shapeAabbMaxs: float*
        ///shapeOffsets: int*
        ///shapePositions: float*
        ///shapeRotations: float*
        ///shapePrevPositions: float*
        ///shapePrevRotations: float*
        ///shapeFlags: int*
        ///numShapes: int
        ///source: FlexMemory
        //public static extern void flexSetShapes(IntPtr s, ref FlexCollisionGeometry geometry, int numGeometryEntries, ref float shapeAabbMins, ref float shapeAabbMaxs, ref int shapeOffsets, ref float shapePositions, ref float shapeRotations, ref float shapePrevPositions, ref float shapePrevRotations, ref int shapeFlags, int numShapes, FlexMemory source);
        // public static extern void flexSetShapes(IntPtr s, FlexCollisionGeometry[] geometry, int numGeometryEntries, Vector4[] shapeAabbMins, Vector4[] shapeAabbMaxs,
        //     int[] shapeOffsets, Vector4[] shapePositions, Quaternion[] shapeRotations, Vector4[] shapePrevPositions, Quaternion[] shapePrevRotations, int[] shapeFlags, int numShapes, FlexMemory source);
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetShapes")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetShapes")]
        #endif

        public static extern void SetShapes(IntPtr s, CollisionTriangleMesh[] triMesh, int numGeometryEntries, Vector4[] shapeAabbMins, Vector4[] shapeAabbMaxs,
       int[] shapeOffsets, Vector4[] shapePositions, Quaternion[] shapeRotations, Vector4[] shapePrevPositions, Quaternion[] shapePrevRotations, int[] shapeFlags, int numShapes, Memory source);


        /// <summary>
        /// Set dynamic triangles mesh indices, typically used for cloth. Flex will calculate normals and apply wind and drag effects to connected particles. See FlexParams::mDrag, FlexParams::mWind.
        /// </summary>
        /// Return Type: void
        ///s: FlexSolver*
        ///indices: int*
        ///normals: float*
        ///numTris: int
        ///source: FlexMemory

        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetDynamicTriangles")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetDynamicTriangles")]
        #endif
        public static extern void SetDynamicTriangles(IntPtr solverPtr, int[] indices, Vector3[] normals, int numTris, Memory source);

        /// <summary>
        /// Get the dynamic triangle indices and normals.
        /// </summary>
        /// Return Type: void
        ///s: FlexSolver*
        ///indices: int*
        ///normals: float*
        ///numTris: int
        ///target: FlexMemory
        #if (UNITY_32 || UNITY_EDITOR_32)
                                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetDynamicTriangles")]
        #else
        [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetDynamicTriangles")]
        #endif
        public static extern void GetDynamicTriangles(IntPtr solverPtr, int[] indices, Vector3[] normals, int numTris, Memory target);

        /// <summary>
        /// Set inflatable shapes, an inflatable is a range of dynamic triangles (wound CCW) that represent a closed mesh. 
        /// Each inflatable has a given rest volume, constraint scale (roughly equivalent to stiffness), 
        /// and "over pressure" that controls how much the shape is inflated.
        /// </summary>
        /// Return Type: void
        ///s: FlexSolver*
        ///startTris: int*
        ///numTris: int*
        ///restVolumes: float*
        ///overPressures: float*
        ///constraintScales: float*
        ///numInflatables: int
        ///source: FlexMemory

        #if (UNITY_32 || UNITY_EDITOR_32)
                                        [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetInflatables")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetInflatables")]
        #endif
        public static extern void SetInflatables(IntPtr solverPtr, int[] startTris, int[] numTris, float[] restVolumes, float[] overPressures, float[] constraintScales, int numInflatables, Memory source);

        /// <summary>
        /// Get the density values for fluid particles
        /// </summary>
        /// Return Type: void
        ///s: FlexSolver*
        ///densities: float*
        ///target: FlexMemory
        [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetDensities")]
        public static extern void GetDensities(IntPtr solverPtr, float[] densities, Memory target);

        [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetDensities")]
        public static extern void GetDensities(IntPtr solverPtr, IntPtr densities, Memory target);

        /// <summary>
        /// 
        /// </summary>
        /// Return Type: void
        ///s: FlexSolver*
        ///q1: float*
        ///q2: float*
        ///q3: float*
        ///target: FlexMemory
        [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetAnisotropy")]
        public static extern void GetAnisotropy(IntPtr solverPtr, ref float q1, ref float q2, ref float q3, Memory target);

        /// <summary>
        /// Get the state of the diffuse particles. Diffuse particles are passively advected by the fluid velocity field.
        /// </summary>
        /// Return Type: int
        ///s: FlexSolver*
        ///p: float*
        ///v: float*
        ///indices: int*
        ///target: FlexMemory
        [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetDiffuseParticles")]
        public static extern int GetDiffuseParticles(IntPtr solverPtr, ref float p, ref float v, ref int indices, Memory target);

        /// <summary>
        /// Set the state of the diffuse particles. Diffuse particles are passively advected by the fluid velocity field.
        /// </summary>
        /// Return Type: void
        ///s: FlexSolver*
        ///p: float*
        ///v: float*
        ///n: int
        ///source: FlexMemory
        [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetDiffuseParticles")]
        public static extern void SetDiffuseParticles(IntPtr solverPtr, ref float p, ref float v, int n, Memory source);

        /// <summary>
        /// Get the particle contact planes. Note this will only include contacts that were active on the last substep of an update, and will include all contact planes generated within FlexParam::mShapeCollisionMargin.
        /// </summary>
        /// Return Type: void
        ///s: FlexSolver*
        ///planes: float*
        ///velocities: float*
        ///indices: int*
        ///counts: unsigned char*
        ///target: FlexMemory
        [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetContacts")]
        public static extern void GetContacts(IntPtr solverPtr, ref float planes, ref float velocities, ref int indices, IntPtr counts, Memory target);

        /// <summary>
        /// Get the world space AABB of all particles in the solver, note that the bounds are calculated during the update (see flexUpdateSolver()) 
        /// so only become valid after an update has been performed. 
        /// The returned bounds represent bounds of the particles in their predicted positions before the constraint solve.
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexGetBounds")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexGetBounds")]
        #endif
        public static extern void GetBounds(IntPtr s, ref Vector3 lower, ref Vector3 upper, Memory target);

        /// <summary>
        /// Allocates size bytes of memory from the optimal memory pool. Using this function is optional, 
        /// but when passed to flexGet/flexSet methods it may result in significantly faster transfers, 
        /// memory used with async transfers should be allocated by this method to ensure optimal performance. 
        /// For CUDA implementations this method will return pinned host memory from cudaMallocHost().
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexAlloc")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexAlloc")]
        #endif
        public static extern IntPtr Alloc(int size);

        /// <summary>
        /// Free memory allocated through flexAlloc
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexFree")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexFree")]
        #endif
        public static extern void Free(IntPtr ptr);

        /// <summary>
        /// Ensures that the CUDA context the library was initialized with is present on the current thread
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexAcquireContext")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexAcquireContext")]
        #endif
        public static extern void AcquireContext();

        /// <summary>
        /// Restores the CUDA context (if any) that was present on the last call to flexAcquireContext()
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexRestoreContext")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexRestoreContext")]
        #endif
        public static extern void RestoreContext();

        /// <summary>
        /// Sets a fence that can be used to synchronize the calling thread with any outstanding GPU work, 
        /// typically used with async transfers to ensure any flexGet/flexSet calls have completed.
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexSetFence")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexSetFence")]
        #endif
        public static extern void SetFence();

        /// <summary>
        /// Waits for the work scheduled before the last call to flexSetFence() to complete 
        /// If flexSetFence() has not yet been called then this is function returns immediately
        /// </summary>
        #if (UNITY_32 || UNITY_EDITOR_32)
                [DllImportAttribute("flexRelease_x86", EntryPoint = "flexWaitFence")]
        #else
                [DllImportAttribute("flexRelease_x64", EntryPoint = "flexWaitFence")]
        #endif
        public static extern void WaitFence();


    }
}