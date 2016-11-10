uFleX v0.45
NVidia FleX for Unity3D
support: korzenio [at] gmail.com
store: http://u3d.as/r50
forum: http://forum.unity3d.com/threads/uflex-nvidia-flex-for-unity3d-unified-visual-fx-released.397836/


uFLeX enables use of NVidia Flex in Unity3D.
FleX is the new GPU accelerated particle simulation library aimed at physically-based visual effects. 
The core idea of FleX is that every object (such as rigid body, soft body or fluids) is represented as a system of particles connected by constraints. 
Such unified representation allows efficient modelling of many different materials and natural interaction between elements of different types, 
for example, two-way coupling between rigid bodies and fluids, or fluids and soft bodies.
See https://developer.nvidia.com/flex for more.

uFleX is under development. Any bug reports and feature requests are more than welcome.



uFleX currently provides:
- Access to low-level Flex native library
- Support for rigid and soft bodies, cloths, fluids, inflatables, ropes, and granular materials
- Deformable mesh rendering
- Screen space fluid rendering via included external package (SSF Pro)
- GUI for straightforward creation of Flex assets
- Example scripted framework for quick integration with your games
- Bunch of example scenes


-----Requirements----
- NVidia GPU with at least CUDA compute capability 3.0
- Latest drivers
- Windows x64 bit (x86, Android and Linux support planned)


----QuickStart-----
1. Import uFlex package
2. If Standard Effects package already imported -> delete uFlex/Standard Assets folder (ImageEffectsBase required for point sprites rendering)
3  In Edit/ProjectSettings/Time decrease the FixedTimestep to 0.01 (the lower the better, but keep it adequate to your hardware capabilities)
4. In the main toolbar select Tools/uFlex
5. If missing, the Flex GameObject will be added to the scene
6. Select body type
7. If Rigid, Soft or Inflatable pick a CLOSED input mesh
8. Click Generate 

Check FlexManual.zip for a complete Flex manual.
For video tutorials subscribe to my channel http://www.youtube.com/playlist?list=PLkKm77tYcGu8Gk1w3033XDuDxoYRpQhHo
To upgrade flex game objects to v0.4 see the guide in Docs folder.

----Screen Space Fluids----
As a uFlex customer you are getting higher quality (HQ) shaders from a future SSF Pro release for free!

Import package from ScreenSpaceFluidsPro folder to enable fluid rendering.
Check the example scenes in ScreenSpaceFluidsPro/uFlex/Scenes

----ChangeLog-----
v0.45
-Ropes rendering
-Fix to FlexParticlesRenderer


v0.4
-Dynamic containers
-Fluid emitters
-Shape-match transforms generation 
-Improved sphere ponints renderer
-Integration with Screen Space Fluids (SSF)
-FlexSolver/Container refactor
-FlexProcessors
-Some bugs fixed

v0.3
-Flex Components refactor
-Fast soft bodies rendering via SkinnedRenderer 
-Ropes
-Inflatables
-Air Meshes
-Update to all demo scenes

v0.2
-Deformable mesh rendering
-Mouse interactions
-Colliders update
-Support for Win32

v0.1 - first public release - early preview
-GUI

v0.05 - pre-release version 
-Rigid bodies
-Soft bodies
-Fluids 
-Cloths

v0.01 - pre-release version 
-fluids vs. triangle mesh collisions

------ToDo------
v0.5 ToDo
-Tearing
-Simulation recording
-Fix collision primitives
-Callbacks
-FlexPlanes

FLEX API:
-collision primitives
-multiple solvers

FLEX EXT:
-callbacks
-tetrahedral bodies

RENDERING:
-ropes rendering

IMPROVEMENTS:
-prevent very long processing times

------Known Issues------
-some rigid bodies drift away. Seems like a problem with Flex's shape matching constraints. I have reported this to NVidia.

------FAQ------
"How do you make it so it actually looks like a liquid instead of looking at the little balls"

 NVidia Flex itself is a pure physics library and uFlex priority is to first cover all the core physics simulation functionality. 
 However, uFlex already provides rigid and soft body mesh rendering via Unity. 

 Fluid rendering is much more complex topic and will take more time to develop and integrate with Unity. 
 Besides porting the GLSL fluid shaders from flex demos it would require adapting them to work with Unity's rendering engine (lights, shadows etc.)
 
 Therefore, the Screen Space Fluids (SSF) rendering is available as a separate asset, which can be used on its own without uFlex, for example, with Unity's particle systems.
 The foreseen paid SSF Pro version will include higher quality fluid shaders and more funcionality. The uFlex customers will get some of its functionality for free.
 
 Alternatively, nothing prevents you from using your own (e.g. screen-space fluids or marching cubes) 
 or 3rd party fluid rendering solutions. Flex already gives access to all the necessary data (even anisotropy of particular particles).﻿