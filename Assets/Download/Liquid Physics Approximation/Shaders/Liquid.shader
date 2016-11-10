// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:1,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:7,dpts:2,wrdp:True,dith:0,rfrpo:False,rfrpn:Refraction,coma:15,ufog:True,aust:False,igpj:False,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:2946,x:33825,y:32940,varname:node_2946,prsc:2|emission-4048-OUT,alpha-9016-OUT,clip-375-OUT,olwid-5099-OUT,olcol-7301-OUT;n:type:ShaderForge.SFN_Color,id:6193,x:32755,y:31867,ptovrint:False,ptlb:Color,ptin:_Color,varname:_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Rotator,id:1711,x:32359,y:33191,varname:node_1711,prsc:2|UVIN-19-OUT,ANG-8870-OUT;n:type:ShaderForge.SFN_ComponentMask,id:8392,x:32832,y:33059,varname:node_8392,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-6535-UVOUT;n:type:ShaderForge.SFN_FragmentPosition,id:4455,x:31349,y:32997,varname:node_4455,prsc:2;n:type:ShaderForge.SFN_ComponentMask,id:19,x:31820,y:33009,varname:node_19,prsc:2,cc1:2,cc2:1,cc3:-1,cc4:-1|IN-9447-OUT;n:type:ShaderForge.SFN_ObjectPosition,id:7440,x:31349,y:32873,varname:node_7440,prsc:2;n:type:ShaderForge.SFN_Append,id:8664,x:32518,y:33191,varname:node_8664,prsc:2|A-629-OUT,B-1711-UVOUT;n:type:ShaderForge.SFN_ComponentMask,id:629,x:31820,y:33156,varname:node_629,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-9447-OUT;n:type:ShaderForge.SFN_ComponentMask,id:3303,x:32675,y:33191,varname:node_3303,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-8664-OUT;n:type:ShaderForge.SFN_Rotator,id:6535,x:32675,y:33060,varname:node_6535,prsc:2|UVIN-3303-OUT,ANG-8945-OUT;n:type:ShaderForge.SFN_Add,id:8870,x:32202,y:33191,varname:node_8870,prsc:2|A-5652-OUT,B-315-OUT;n:type:ShaderForge.SFN_Vector1,id:5652,x:32045,y:33156,varname:node_5652,prsc:2,v1:1.55;n:type:ShaderForge.SFN_ValueProperty,id:8945,x:32518,y:33109,ptovrint:False,ptlb:RotationX,ptin:_RotationX,varname:_RotationX,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:315,x:32045,y:33235,ptovrint:False,ptlb:RotationZ,ptin:_RotationZ,varname:_RotationZ,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Fresnel,id:3405,x:32755,y:32015,varname:node_3405,prsc:2|EXP-1871-OUT;n:type:ShaderForge.SFN_Multiply,id:5474,x:33067,y:32015,varname:node_5474,prsc:2|A-3405-OUT,B-6193-RGB;n:type:ShaderForge.SFN_OneMinus,id:7318,x:32912,y:31935,varname:node_7318,prsc:2|IN-3405-OUT;n:type:ShaderForge.SFN_Multiply,id:5114,x:33067,y:31861,varname:node_5114,prsc:2|A-7465-OUT,B-7318-OUT;n:type:ShaderForge.SFN_Subtract,id:7465,x:32912,y:31791,varname:node_7465,prsc:2|A-6193-RGB,B-6858-OUT;n:type:ShaderForge.SFN_Add,id:4091,x:33216,y:31928,varname:node_4091,prsc:2|A-5114-OUT,B-5474-OUT;n:type:ShaderForge.SFN_Vector1,id:1871,x:32582,y:32074,varname:node_1871,prsc:2,v1:0.7;n:type:ShaderForge.SFN_Subtract,id:2456,x:31513,y:32948,varname:node_2456,prsc:2|A-7440-XYZ,B-4455-XYZ;n:type:ShaderForge.SFN_Blend,id:1754,x:32989,y:33139,varname:node_1754,prsc:2,blmd:8,clmp:False|SRC-8392-OUT,DST-8141-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8141,x:32832,y:33235,ptovrint:False,ptlb:Amount,ptin:_Amount,varname:_Amount,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Append,id:6858,x:32755,y:31699,varname:node_6858,prsc:2|A-4719-OUT,B-4719-OUT,C-4719-OUT;n:type:ShaderForge.SFN_Vector1,id:4719,x:32589,y:31718,varname:node_4719,prsc:2,v1:0.3;n:type:ShaderForge.SFN_Tex2d,id:3616,x:33301,y:32814,ptovrint:False,ptlb:StaticAnimationSlicePattern,ptin:_StaticAnimationSlicePattern,varname:_StaticAnimationSlicePattern,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:3a5a96df060a5cf4a9cc0c59e13486b7,ntxv:0,isnm:False|UVIN-8683-UVOUT;n:type:ShaderForge.SFN_Panner,id:8683,x:33145,y:32814,varname:node_8683,prsc:2,spu:-1,spv:0|UVIN-9494-OUT,DIST-4924-OUT;n:type:ShaderForge.SFN_ComponentMask,id:390,x:32593,y:32359,varname:node_390,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-6535-UVOUT;n:type:ShaderForge.SFN_Append,id:9494,x:32908,y:32379,varname:node_9494,prsc:2|A-2037-OUT,B-9792-OUT;n:type:ShaderForge.SFN_Multiply,id:2037,x:32752,y:32319,varname:node_2037,prsc:2|A-8696-OUT,B-390-R;n:type:ShaderForge.SFN_Slider,id:821,x:32675,y:32900,ptovrint:False,ptlb:StaticAnimationSliceSpeed,ptin:_StaticAnimationSliceSpeed,varname:_StaticAnimationSliceSpeed,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:0.5,max:10;n:type:ShaderForge.SFN_Multiply,id:4924,x:32989,y:32814,varname:node_4924,prsc:2|A-8815-T,B-821-OUT;n:type:ShaderForge.SFN_Time,id:8815,x:32753,y:32747,varname:node_8815,prsc:2;n:type:ShaderForge.SFN_SwitchProperty,id:8357,x:33301,y:33007,ptovrint:False,ptlb:EnableStaticAnimation,ptin:_EnableStaticAnimation,varname:_EnableStaticAnimation,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:True|A-4855-OUT,B-3616-R;n:type:ShaderForge.SFN_Slider,id:1497,x:32436,y:32525,ptovrint:False,ptlb:StaticAnimationSliceHeight,ptin:_StaticAnimationSliceHeight,varname:_StaticAnimationSliceHeight,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:0.2,max:0.5;n:type:ShaderForge.SFN_Slider,id:8696,x:32436,y:32285,ptovrint:False,ptlb:StaticAnimationSliceDensity,ptin:_StaticAnimationSliceDensity,varname:_StaticAnimationSliceDensity,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:0.1,max:10;n:type:ShaderForge.SFN_Vector1,id:4855,x:33145,y:33007,varname:node_4855,prsc:2,v1:0;n:type:ShaderForge.SFN_Blend,id:9792,x:32751,y:32451,varname:node_9792,prsc:2,blmd:5,clmp:False|SRC-390-G,DST-1497-OUT;n:type:ShaderForge.SFN_Blend,id:375,x:33618,y:33007,varname:node_375,prsc:2,blmd:6,clmp:False|SRC-2855-OUT,DST-1754-OUT;n:type:ShaderForge.SFN_Vector1,id:9016,x:33618,y:32928,varname:node_9016,prsc:2,v1:0.8;n:type:ShaderForge.SFN_Vector1,id:5099,x:33618,y:33199,varname:node_5099,prsc:2,v1:-0.01;n:type:ShaderForge.SFN_Vector3,id:6967,x:33308,y:33199,varname:node_6967,prsc:2,v1:0.3,v2:0.3,v3:0.3;n:type:ShaderForge.SFN_Tex2d,id:9712,x:33216,y:31768,ptovrint:False,ptlb:Gradient,ptin:_Gradient,varname:_Gradient,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:4048,x:33379,y:31864,varname:node_4048,prsc:2|A-9712-R,B-4091-OUT;n:type:ShaderForge.SFN_Subtract,id:8548,x:33465,y:33199,varname:node_8548,prsc:2|A-6193-RGB,B-6967-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:7301,x:33618,y:33294,ptovrint:False,ptlb:EnableCustomTopColor,ptin:_EnableCustomTopColor,varname:_EnableCustomTopColor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-8548-OUT,B-8497-RGB;n:type:ShaderForge.SFN_Color,id:8497,x:33465,y:33366,ptovrint:False,ptlb:TopColor,ptin:_TopColor,varname:_TopColor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.7,c2:0.7,c3:0.7,c4:1;n:type:ShaderForge.SFN_Multiply,id:2855,x:33459,y:33007,varname:node_2855,prsc:2|A-8357-OUT,B-1497-OUT;n:type:ShaderForge.SFN_FaceSign,id:2064,x:33379,y:32003,varname:node_2064,prsc:2,fstp:0;n:type:ShaderForge.SFN_Blend,id:3536,x:33542,y:31941,varname:node_3536,prsc:2,blmd:0,clmp:False|SRC-4048-OUT,DST-2064-VFACE;n:type:ShaderForge.SFN_Vector4Property,id:6674,x:31349,y:33186,ptovrint:False,ptlb:Pivot,ptin:_Pivot,varname:node_6674,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0,v2:0,v3:0,v4:0;n:type:ShaderForge.SFN_Append,id:5567,x:31513,y:33186,varname:node_5567,prsc:2|A-6674-X,B-6674-Y,C-6674-Z;n:type:ShaderForge.SFN_Blend,id:9447,x:31659,y:33089,varname:node_9447,prsc:2,blmd:6,clmp:False|SRC-2456-OUT,DST-5567-OUT;proporder:9712-6193-7301-8497-8357-8141-8696-3616-1497-821-6674-8945-315;pass:END;sub:END;*/

Shader "Liquid Physics Approximation/Liquid" {
    Properties {
        _Gradient ("Gradient", 2D) = "white" {}
        _Color ("Color", Color) = (1,1,1,1)
        [MaterialToggle] _EnableCustomTopColor ("EnableCustomTopColor", Float ) = 0.7
        _TopColor ("TopColor", Color) = (0.7,0.7,0.7,1)
        [MaterialToggle] _EnableStaticAnimation ("EnableStaticAnimation", Float ) = 0
        _Amount ("Amount", Float ) = 0.5
        _StaticAnimationSliceDensity ("StaticAnimationSliceDensity", Range(0.1, 10)) = 0.1
        _StaticAnimationSlicePattern ("StaticAnimationSlicePattern", 2D) = "white" {}
        _StaticAnimationSliceHeight ("StaticAnimationSliceHeight", Range(0.1, 0.5)) = 0.2
        _StaticAnimationSliceSpeed ("StaticAnimationSliceSpeed", Range(0.1, 10)) = 0.5
        _Pivot ("Pivot", Vector) = (0,0,0,0)
        _RotationX ("RotationX", Float ) = 0
        _RotationZ ("RotationZ", Float ) = 0
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "Outline"
            Tags {
            }
            Cull Front
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform float _RotationX;
            uniform float _RotationZ;
            uniform float _Amount;
            uniform sampler2D _StaticAnimationSlicePattern; uniform float4 _StaticAnimationSlicePattern_ST;
            uniform float _StaticAnimationSliceSpeed;
            uniform fixed _EnableStaticAnimation;
            uniform float _StaticAnimationSliceHeight;
            uniform float _StaticAnimationSliceDensity;
            uniform fixed _EnableCustomTopColor;
            uniform float4 _TopColor;
            uniform float4 _Pivot;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, float4(v.vertex.xyz + v.normal*(-0.01),1) );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                float4 node_8815 = _Time + _TimeEditor;
                float node_6535_ang = _RotationX;
                float node_6535_spd = 1.0;
                float node_6535_cos = cos(node_6535_spd*node_6535_ang);
                float node_6535_sin = sin(node_6535_spd*node_6535_ang);
                float2 node_6535_piv = float2(0.5,0.5);
                float3 node_9447 = (1.0-(1.0-(objPos.rgb-i.posWorld.rgb))*(1.0-float3(_Pivot.r,_Pivot.g,_Pivot.b)));
                float node_1711_ang = (1.55+_RotationZ);
                float node_1711_spd = 1.0;
                float node_1711_cos = cos(node_1711_spd*node_1711_ang);
                float node_1711_sin = sin(node_1711_spd*node_1711_ang);
                float2 node_1711_piv = float2(0.5,0.5);
                float2 node_1711 = (mul(node_9447.bg-node_1711_piv,float2x2( node_1711_cos, -node_1711_sin, node_1711_sin, node_1711_cos))+node_1711_piv);
                float2 node_6535 = (mul(float3(node_9447.r,node_1711).rg-node_6535_piv,float2x2( node_6535_cos, -node_6535_sin, node_6535_sin, node_6535_cos))+node_6535_piv);
                float2 node_390 = node_6535.rg;
                float2 node_8683 = (float2((_StaticAnimationSliceDensity*node_390.r),max(node_390.g,_StaticAnimationSliceHeight))+(node_8815.g*_StaticAnimationSliceSpeed)*float2(-1,0));
                float4 _StaticAnimationSlicePattern_var = tex2D(_StaticAnimationSlicePattern,TRANSFORM_TEX(node_8683, _StaticAnimationSlicePattern));
                clip((1.0-(1.0-(lerp( 0.0, _StaticAnimationSlicePattern_var.r, _EnableStaticAnimation )*_StaticAnimationSliceHeight))*(1.0-(node_6535.g+_Amount))) - 0.5);
                return fixed4(lerp( (_Color.rgb-float3(0.3,0.3,0.3)), _TopColor.rgb, _EnableCustomTopColor ),0);
            }
            ENDCG
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One OneMinusSrcAlpha
            Cull Off
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform float _RotationX;
            uniform float _RotationZ;
            uniform float _Amount;
            uniform sampler2D _StaticAnimationSlicePattern; uniform float4 _StaticAnimationSlicePattern_ST;
            uniform float _StaticAnimationSliceSpeed;
            uniform fixed _EnableStaticAnimation;
            uniform float _StaticAnimationSliceHeight;
            uniform float _StaticAnimationSliceDensity;
            uniform sampler2D _Gradient; uniform float4 _Gradient_ST;
            uniform float4 _Pivot;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                UNITY_FOG_COORDS(3)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float4 node_8815 = _Time + _TimeEditor;
                float node_6535_ang = _RotationX;
                float node_6535_spd = 1.0;
                float node_6535_cos = cos(node_6535_spd*node_6535_ang);
                float node_6535_sin = sin(node_6535_spd*node_6535_ang);
                float2 node_6535_piv = float2(0.5,0.5);
                float3 node_9447 = (1.0-(1.0-(objPos.rgb-i.posWorld.rgb))*(1.0-float3(_Pivot.r,_Pivot.g,_Pivot.b)));
                float node_1711_ang = (1.55+_RotationZ);
                float node_1711_spd = 1.0;
                float node_1711_cos = cos(node_1711_spd*node_1711_ang);
                float node_1711_sin = sin(node_1711_spd*node_1711_ang);
                float2 node_1711_piv = float2(0.5,0.5);
                float2 node_1711 = (mul(node_9447.bg-node_1711_piv,float2x2( node_1711_cos, -node_1711_sin, node_1711_sin, node_1711_cos))+node_1711_piv);
                float2 node_6535 = (mul(float3(node_9447.r,node_1711).rg-node_6535_piv,float2x2( node_6535_cos, -node_6535_sin, node_6535_sin, node_6535_cos))+node_6535_piv);
                float2 node_390 = node_6535.rg;
                float2 node_8683 = (float2((_StaticAnimationSliceDensity*node_390.r),max(node_390.g,_StaticAnimationSliceHeight))+(node_8815.g*_StaticAnimationSliceSpeed)*float2(-1,0));
                float4 _StaticAnimationSlicePattern_var = tex2D(_StaticAnimationSlicePattern,TRANSFORM_TEX(node_8683, _StaticAnimationSlicePattern));
                clip((1.0-(1.0-(lerp( 0.0, _StaticAnimationSlicePattern_var.r, _EnableStaticAnimation )*_StaticAnimationSliceHeight))*(1.0-(node_6535.g+_Amount))) - 0.5);
////// Lighting:
////// Emissive:
                float4 _Gradient_var = tex2D(_Gradient,TRANSFORM_TEX(i.uv0, _Gradient));
                float node_4719 = 0.3;
                float node_3405 = pow(1.0-max(0,dot(normalDirection, viewDirection)),0.7);
                float3 node_4048 = (_Gradient_var.r*(((_Color.rgb-float3(node_4719,node_4719,node_4719))*(1.0 - node_3405))+(node_3405*_Color.rgb)));
                float3 emissive = node_4048;
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,0.8);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float _RotationX;
            uniform float _RotationZ;
            uniform float _Amount;
            uniform sampler2D _StaticAnimationSlicePattern; uniform float4 _StaticAnimationSlicePattern_ST;
            uniform float _StaticAnimationSliceSpeed;
            uniform fixed _EnableStaticAnimation;
            uniform float _StaticAnimationSliceHeight;
            uniform float _StaticAnimationSliceDensity;
            uniform float4 _Pivot;
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float4 posWorld : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                float4 node_8815 = _Time + _TimeEditor;
                float node_6535_ang = _RotationX;
                float node_6535_spd = 1.0;
                float node_6535_cos = cos(node_6535_spd*node_6535_ang);
                float node_6535_sin = sin(node_6535_spd*node_6535_ang);
                float2 node_6535_piv = float2(0.5,0.5);
                float3 node_9447 = (1.0-(1.0-(objPos.rgb-i.posWorld.rgb))*(1.0-float3(_Pivot.r,_Pivot.g,_Pivot.b)));
                float node_1711_ang = (1.55+_RotationZ);
                float node_1711_spd = 1.0;
                float node_1711_cos = cos(node_1711_spd*node_1711_ang);
                float node_1711_sin = sin(node_1711_spd*node_1711_ang);
                float2 node_1711_piv = float2(0.5,0.5);
                float2 node_1711 = (mul(node_9447.bg-node_1711_piv,float2x2( node_1711_cos, -node_1711_sin, node_1711_sin, node_1711_cos))+node_1711_piv);
                float2 node_6535 = (mul(float3(node_9447.r,node_1711).rg-node_6535_piv,float2x2( node_6535_cos, -node_6535_sin, node_6535_sin, node_6535_cos))+node_6535_piv);
                float2 node_390 = node_6535.rg;
                float2 node_8683 = (float2((_StaticAnimationSliceDensity*node_390.r),max(node_390.g,_StaticAnimationSliceHeight))+(node_8815.g*_StaticAnimationSliceSpeed)*float2(-1,0));
                float4 _StaticAnimationSlicePattern_var = tex2D(_StaticAnimationSlicePattern,TRANSFORM_TEX(node_8683, _StaticAnimationSlicePattern));
                clip((1.0-(1.0-(lerp( 0.0, _StaticAnimationSlicePattern_var.r, _EnableStaticAnimation )*_StaticAnimationSliceHeight))*(1.0-(node_6535.g+_Amount))) - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #include "UnityCG.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _Color;
            uniform sampler2D _Gradient; uniform float4 _Gradient_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : SV_Target {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                float4 _Gradient_var = tex2D(_Gradient,TRANSFORM_TEX(i.uv0, _Gradient));
                float node_4719 = 0.3;
                float node_3405 = pow(1.0-max(0,dot(normalDirection, viewDirection)),0.7);
                float3 node_4048 = (_Gradient_var.r*(((_Color.rgb-float3(node_4719,node_4719,node_4719))*(1.0 - node_3405))+(node_3405*_Color.rgb)));
                o.Emission = node_4048;
                
                float3 diffColor = float3(0,0,0);
                o.Albedo = diffColor;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
