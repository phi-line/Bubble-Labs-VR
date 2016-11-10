// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'
// Upgrade NOTE: replaced '_World2Object' with 'unity_WorldToObject'

// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:3,bdst:7,dpts:2,wrdp:True,dith:0,rfrpo:False,rfrpn:Refraction,coma:15,ufog:False,aust:False,igpj:False,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:32909,y:32846,varname:node_3138,prsc:2|emission-6677-OUT,alpha-8685-OUT,clip-8685-OUT;n:type:ShaderForge.SFN_Tex2d,id:8784,x:32579,y:32813,ptovrint:False,ptlb:Pattern,ptin:_Pattern,varname:node_8784,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:3a5a96df060a5cf4a9cc0c59e13486b7,ntxv:0,isnm:False|UVIN-2246-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:7643,x:32106,y:32665,varname:node_7643,prsc:2,uv:0;n:type:ShaderForge.SFN_ValueProperty,id:228,x:31949,y:32878,ptovrint:False,ptlb:PatternTiling,ptin:_PatternTiling,varname:node_228,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:6959,x:32261,y:32794,varname:node_6959,prsc:2|A-7643-UVOUT,B-3580-OUT;n:type:ShaderForge.SFN_Time,id:1290,x:32106,y:32955,varname:node_1290,prsc:2;n:type:ShaderForge.SFN_Add,id:604,x:32262,y:33021,varname:node_604,prsc:2|A-1290-TDB,B-1398-OUT;n:type:ShaderForge.SFN_Slider,id:1398,x:31949,y:33099,ptovrint:False,ptlb:PatternSpeed,ptin:_PatternSpeed,varname:node_1398,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:0.1,max:10;n:type:ShaderForge.SFN_Panner,id:2246,x:32421,y:32909,varname:node_2246,prsc:2,spu:0,spv:-1|UVIN-6959-OUT,DIST-604-OUT;n:type:ShaderForge.SFN_Rotator,id:6358,x:31946,y:33361,varname:node_6358,prsc:2|UVIN-9210-OUT,ANG-4123-OUT;n:type:ShaderForge.SFN_ComponentMask,id:1702,x:32419,y:33229,varname:node_1702,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-2276-UVOUT;n:type:ShaderForge.SFN_ComponentMask,id:9210,x:31407,y:33179,varname:node_9210,prsc:2,cc1:2,cc2:1,cc3:-1,cc4:-1|IN-5931-OUT;n:type:ShaderForge.SFN_Append,id:6850,x:32105,y:33361,varname:node_6850,prsc:2|A-8149-OUT,B-6358-UVOUT;n:type:ShaderForge.SFN_ComponentMask,id:8149,x:31407,y:33326,varname:node_8149,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-5931-OUT;n:type:ShaderForge.SFN_ComponentMask,id:6312,x:32262,y:33361,varname:node_6312,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-6850-OUT;n:type:ShaderForge.SFN_Rotator,id:2276,x:32262,y:33230,varname:node_2276,prsc:2|UVIN-6312-OUT,ANG-6783-OUT;n:type:ShaderForge.SFN_Add,id:4123,x:31789,y:33361,varname:node_4123,prsc:2|A-6802-OUT,B-4987-OUT;n:type:ShaderForge.SFN_Vector1,id:6802,x:31632,y:33326,varname:node_6802,prsc:2,v1:1.55;n:type:ShaderForge.SFN_ValueProperty,id:6783,x:32105,y:33279,ptovrint:False,ptlb:RotationX,ptin:_RotationX,varname:node_8945,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:4987,x:31632,y:33405,ptovrint:False,ptlb:RotationZ,ptin:_RotationZ,varname:node_315,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Blend,id:7308,x:32576,y:33309,varname:node_7308,prsc:2,blmd:8,clmp:False|SRC-1702-OUT,DST-9552-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9552,x:32419,y:33405,ptovrint:False,ptlb:Amount,ptin:_Amount,varname:node_8141,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Multiply,id:8685,x:32724,y:33183,varname:node_8685,prsc:2|A-8784-R,B-7308-OUT;n:type:ShaderForge.SFN_Multiply,id:3580,x:32106,y:32812,varname:node_3580,prsc:2|A-4226-XYZ,B-228-OUT;n:type:ShaderForge.SFN_ObjectScale,id:4226,x:31949,y:32712,varname:node_4226,prsc:2,rcp:False;n:type:ShaderForge.SFN_FragmentPosition,id:71,x:30931,y:33157,varname:node_71,prsc:2;n:type:ShaderForge.SFN_ObjectPosition,id:8812,x:30931,y:33033,varname:node_8812,prsc:2;n:type:ShaderForge.SFN_Subtract,id:5934,x:31095,y:33108,varname:node_5934,prsc:2|A-8812-XYZ,B-71-XYZ;n:type:ShaderForge.SFN_Vector4Property,id:6117,x:30931,y:33346,ptovrint:False,ptlb:Pivot,ptin:_Pivot,varname:node_6674,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0,v2:0,v3:0,v4:0;n:type:ShaderForge.SFN_Append,id:338,x:31095,y:33346,varname:node_338,prsc:2|A-6117-X,B-6117-Y,C-6117-Z;n:type:ShaderForge.SFN_Blend,id:5931,x:31241,y:33249,varname:node_5931,prsc:2,blmd:6,clmp:False|SRC-5934-OUT,DST-338-OUT;n:type:ShaderForge.SFN_Multiply,id:6677,x:32724,y:32928,varname:node_6677,prsc:2|A-8784-RGB,B-5326-RGB;n:type:ShaderForge.SFN_Color,id:5326,x:32579,y:32993,ptovrint:False,ptlb:PatternColor,ptin:_PatternColor,varname:node_5326,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;proporder:8784-228-1398-9552-6117-6783-4987-5326;pass:END;sub:END;*/

Shader "Liquid Physics Approximation/Liquid bubbles" {
    Properties {
        _Pattern ("Pattern", 2D) = "white" {}
        _PatternTiling ("PatternTiling", Float ) = 1
        _PatternSpeed ("PatternSpeed", Range(0.1, 10)) = 0.1
        _Amount ("Amount", Float ) = 0.5
        _Pivot ("Pivot", Vector) = (0,0,0,0)
        _RotationX ("RotationX", Float ) = 0
        _RotationZ ("RotationZ", Float ) = 0
        _PatternColor ("PatternColor", Color) = (0.5,0.5,0.5,1)
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            Cull Off
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _Pattern; uniform float4 _Pattern_ST;
            uniform float _PatternTiling;
            uniform float _PatternSpeed;
            uniform float _RotationX;
            uniform float _RotationZ;
            uniform float _Amount;
            uniform float4 _Pivot;
            uniform float4 _PatternColor;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                float3 recipObjScale = float3( length(unity_WorldToObject[0].xyz), length(unity_WorldToObject[1].xyz), length(unity_WorldToObject[2].xyz) );
                float3 objScale = 1.0/recipObjScale;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                float3 recipObjScale = float3( length(unity_WorldToObject[0].xyz), length(unity_WorldToObject[1].xyz), length(unity_WorldToObject[2].xyz) );
                float3 objScale = 1.0/recipObjScale;
                float4 node_1290 = _Time + _TimeEditor;
                float2 node_2246 = ((float3(i.uv0,0.0)*(objScale*_PatternTiling))+(node_1290.b+_PatternSpeed)*float2(0,-1));
                float4 _Pattern_var = tex2D(_Pattern,TRANSFORM_TEX(node_2246, _Pattern));
                float node_2276_ang = _RotationX;
                float node_2276_spd = 1.0;
                float node_2276_cos = cos(node_2276_spd*node_2276_ang);
                float node_2276_sin = sin(node_2276_spd*node_2276_ang);
                float2 node_2276_piv = float2(0.5,0.5);
                float3 node_5931 = (1.0-(1.0-(objPos.rgb-i.posWorld.rgb))*(1.0-float3(_Pivot.r,_Pivot.g,_Pivot.b)));
                float node_6358_ang = (1.55+_RotationZ);
                float node_6358_spd = 1.0;
                float node_6358_cos = cos(node_6358_spd*node_6358_ang);
                float node_6358_sin = sin(node_6358_spd*node_6358_ang);
                float2 node_6358_piv = float2(0.5,0.5);
                float2 node_6358 = (mul(node_5931.bg-node_6358_piv,float2x2( node_6358_cos, -node_6358_sin, node_6358_sin, node_6358_cos))+node_6358_piv);
                float2 node_2276 = (mul(float3(node_5931.r,node_6358).rg-node_2276_piv,float2x2( node_2276_cos, -node_2276_sin, node_2276_sin, node_2276_cos))+node_2276_piv);
                float node_8685 = (_Pattern_var.r*(node_2276.g+_Amount));
                clip(node_8685 - 0.5);
////// Lighting:
////// Emissive:
                float3 emissive = (_Pattern_var.rgb*_PatternColor.rgb);
                float3 finalColor = emissive;
                return fixed4(finalColor,node_8685);
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
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _Pattern; uniform float4 _Pattern_ST;
            uniform float _PatternTiling;
            uniform float _PatternSpeed;
            uniform float _RotationX;
            uniform float _RotationZ;
            uniform float _Amount;
            uniform float4 _Pivot;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float4 posWorld : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                float3 recipObjScale = float3( length(unity_WorldToObject[0].xyz), length(unity_WorldToObject[1].xyz), length(unity_WorldToObject[2].xyz) );
                float3 objScale = 1.0/recipObjScale;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                float3 recipObjScale = float3( length(unity_WorldToObject[0].xyz), length(unity_WorldToObject[1].xyz), length(unity_WorldToObject[2].xyz) );
                float3 objScale = 1.0/recipObjScale;
                float4 node_1290 = _Time + _TimeEditor;
                float2 node_2246 = ((float3(i.uv0,0.0)*(objScale*_PatternTiling))+(node_1290.b+_PatternSpeed)*float2(0,-1));
                float4 _Pattern_var = tex2D(_Pattern,TRANSFORM_TEX(node_2246, _Pattern));
                float node_2276_ang = _RotationX;
                float node_2276_spd = 1.0;
                float node_2276_cos = cos(node_2276_spd*node_2276_ang);
                float node_2276_sin = sin(node_2276_spd*node_2276_ang);
                float2 node_2276_piv = float2(0.5,0.5);
                float3 node_5931 = (1.0-(1.0-(objPos.rgb-i.posWorld.rgb))*(1.0-float3(_Pivot.r,_Pivot.g,_Pivot.b)));
                float node_6358_ang = (1.55+_RotationZ);
                float node_6358_spd = 1.0;
                float node_6358_cos = cos(node_6358_spd*node_6358_ang);
                float node_6358_sin = sin(node_6358_spd*node_6358_ang);
                float2 node_6358_piv = float2(0.5,0.5);
                float2 node_6358 = (mul(node_5931.bg-node_6358_piv,float2x2( node_6358_cos, -node_6358_sin, node_6358_sin, node_6358_cos))+node_6358_piv);
                float2 node_2276 = (mul(float3(node_5931.r,node_6358).rg-node_2276_piv,float2x2( node_2276_cos, -node_2276_sin, node_2276_sin, node_2276_cos))+node_2276_piv);
                float node_8685 = (_Pattern_var.r*(node_2276.g+_Amount));
                clip(node_8685 - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
