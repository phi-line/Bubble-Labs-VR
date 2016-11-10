// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:3,spmd:1,trmd:1,grmd:1,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:True,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:1,bsrc:0,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:False,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3730,x:33824,y:33005,varname:node_3730,prsc:2|diff-9482-RGB,spec-2140-OUT,gloss-1623-OUT,emission-3689-OUT,alpha-5305-OUT;n:type:ShaderForge.SFN_Fresnel,id:8614,x:32814,y:33033,varname:node_8614,prsc:2|EXP-2165-OUT;n:type:ShaderForge.SFN_Color,id:9482,x:32814,y:32886,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_9482,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Slider,id:2165,x:32499,y:33060,ptovrint:False,ptlb:FresnelOpacity,ptin:_FresnelOpacity,varname:node_2165,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:3,max:5;n:type:ShaderForge.SFN_Tex2d,id:5333,x:32499,y:33161,ptovrint:False,ptlb:MainPattern,ptin:_MainPattern,varname:node_5333,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:2,isnm:False|UVIN-5235-OUT;n:type:ShaderForge.SFN_Multiply,id:5235,x:32343,y:33161,varname:node_5235,prsc:2|A-5141-UVOUT,B-6517-OUT;n:type:ShaderForge.SFN_TexCoord,id:5141,x:32159,y:33092,varname:node_5141,prsc:2,uv:0;n:type:ShaderForge.SFN_Vector1,id:2140,x:32814,y:32618,varname:node_2140,prsc:2,v1:0;n:type:ShaderForge.SFN_OneMinus,id:9402,x:32656,y:33161,varname:node_9402,prsc:2|IN-5333-R;n:type:ShaderForge.SFN_Multiply,id:174,x:33135,y:33452,varname:node_174,prsc:2|A-9482-RGB,B-9402-OUT;n:type:ShaderForge.SFN_Blend,id:6503,x:33446,y:33505,varname:node_6503,prsc:2,blmd:6,clmp:False|SRC-4915-OUT,DST-8009-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6517,x:32159,y:33262,ptovrint:False,ptlb:MainPatternTiling,ptin:_MainPatternTiling,varname:node_6517,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:8009,x:33290,y:33505,varname:node_8009,prsc:2|A-174-OUT,B-1989-OUT;n:type:ShaderForge.SFN_Tex2d,id:5741,x:32973,y:33498,ptovrint:False,ptlb:TranslucencyPattern,ptin:_TranslucencyPattern,varname:node_5741,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-5162-OUT;n:type:ShaderForge.SFN_Time,id:8187,x:31864,y:33472,varname:node_8187,prsc:2;n:type:ShaderForge.SFN_Vector1,id:6302,x:32973,y:33661,varname:node_6302,prsc:2,v1:0.999;n:type:ShaderForge.SFN_Step,id:1989,x:33135,y:33579,varname:node_1989,prsc:2|A-5741-R,B-6302-OUT;n:type:ShaderForge.SFN_Add,id:6457,x:32656,y:33440,varname:node_6457,prsc:2|A-1683-R,B-6861-OUT;n:type:ShaderForge.SFN_Slider,id:1281,x:32002,y:33448,ptovrint:False,ptlb:TranslucencyPatternSpeed X,ptin:_TranslucencyPatternSpeedX,varname:node_1281,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1,max:1;n:type:ShaderForge.SFN_Multiply,id:6861,x:32343,y:33438,varname:node_6861,prsc:2|A-1281-OUT,B-8187-TDB;n:type:ShaderForge.SFN_Append,id:5162,x:32814,y:33498,varname:node_5162,prsc:2|A-6457-OUT,B-5106-OUT;n:type:ShaderForge.SFN_Slider,id:2136,x:32002,y:33575,ptovrint:False,ptlb:TranslucencyPatternSpeed Y,ptin:_TranslucencyPatternSpeedY,varname:node_2136,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1,max:1;n:type:ShaderForge.SFN_Multiply,id:9572,x:32343,y:33565,varname:node_9572,prsc:2|A-8187-TDB,B-2136-OUT;n:type:ShaderForge.SFN_Add,id:5106,x:32656,y:33567,varname:node_5106,prsc:2|A-1683-G,B-9572-OUT;n:type:ShaderForge.SFN_ComponentMask,id:1683,x:32499,y:33487,varname:node_1683,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-8463-OUT;n:type:ShaderForge.SFN_Multiply,id:8463,x:32343,y:33294,varname:node_8463,prsc:2|A-5141-UVOUT,B-1349-OUT;n:type:ShaderForge.SFN_ValueProperty,id:1349,x:32159,y:33351,ptovrint:False,ptlb:TranslucencyPatternTiling,ptin:_TranslucencyPatternTiling,varname:node_1349,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_SwitchProperty,id:3689,x:33603,y:33505,ptovrint:False,ptlb:AddTranslucencyPatternEmission,ptin:_AddTranslucencyPatternEmission,varname:node_3689,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:True|A-4915-OUT,B-6503-OUT;n:type:ShaderForge.SFN_Blend,id:4915,x:32973,y:32962,varname:node_4915,prsc:2,blmd:1,clmp:False|SRC-9482-RGB,DST-8614-OUT;n:type:ShaderForge.SFN_Add,id:5305,x:33603,y:33340,varname:node_5305,prsc:2|A-8614-OUT,B-729-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:729,x:33446,y:33340,ptovrint:False,ptlb:AddedFresnel,ptin:_AddedFresnel,varname:node_729,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-2140-OUT,B-9402-OUT;n:type:ShaderForge.SFN_Slider,id:7607,x:32657,y:32741,ptovrint:False,ptlb:Reflectivity,ptin:_Reflectivity,varname:node_7607,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:0.5,max:1;n:type:ShaderForge.SFN_OneMinus,id:1623,x:32973,y:32741,varname:node_1623,prsc:2|IN-7607-OUT;proporder:9482-2165-729-5333-6517-3689-5741-1281-2136-1349-7607;pass:END;sub:END;*/

Shader "Liquid Physics Approximation/Front glass" {
    Properties {
        _Color ("Color", Color) = (1,1,1,1)
        _FresnelOpacity ("FresnelOpacity", Range(0, 5)) = 3
        [MaterialToggle] _AddedFresnel ("AddedFresnel", Float ) = 0
        _MainPattern ("MainPattern", 2D) = "black" {}
        _MainPatternTiling ("MainPatternTiling", Float ) = 1
        [MaterialToggle] _AddTranslucencyPatternEmission ("AddTranslucencyPatternEmission", Float ) = 1
        _TranslucencyPattern ("TranslucencyPattern", 2D) = "white" {}
        _TranslucencyPatternSpeedX ("TranslucencyPatternSpeed X", Range(0, 1)) = 0.1
        _TranslucencyPatternSpeedY ("TranslucencyPatternSpeed Y", Range(0, 1)) = 0.1
        _TranslucencyPatternTiling ("TranslucencyPatternTiling", Float ) = 1
        _Reflectivity ("Reflectivity", Range(0.1, 1)) = 0.5
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One OneMinusSrcAlpha
            Cull Front
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform float _FresnelOpacity;
            uniform sampler2D _MainPattern; uniform float4 _MainPattern_ST;
            uniform float _MainPatternTiling;
            uniform sampler2D _TranslucencyPattern; uniform float4 _TranslucencyPattern_ST;
            uniform float _TranslucencyPatternSpeedX;
            uniform float _TranslucencyPatternSpeedY;
            uniform float _TranslucencyPatternTiling;
            uniform fixed _AddTranslucencyPatternEmission;
            uniform fixed _AddedFresnel;
            uniform float _Reflectivity;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                UNITY_FOG_COORDS(7)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD8;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                #ifdef LIGHTMAP_ON
                    o.ambientOrLightmapUV.xy = v.texcoord1.xy * unity_LightmapST.xy + unity_LightmapST.zw;
                    o.ambientOrLightmapUV.zw = 0;
                #elif UNITY_SHOULD_SAMPLE_SH
                #endif
                #ifdef DYNAMICLIGHTMAP_ON
                    o.ambientOrLightmapUV.zw = v.texcoord2.xy * unity_DynamicLightmapST.xy + unity_DynamicLightmapST.zw;
                #endif
                o.normalDir = UnityObjectToWorldNormal(-v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = 1.0 - (1.0 - _Reflectivity); // Convert roughness to gloss
                float specPow = exp2( gloss * 10.0+1.0);
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                #if defined(LIGHTMAP_ON) || defined(DYNAMICLIGHTMAP_ON)
                    d.ambient = 0;
                    d.lightmapUV = i.ambientOrLightmapUV;
                #else
                    d.ambient = i.ambientOrLightmapUV;
                #endif
                d.boxMax[0] = unity_SpecCube0_BoxMax;
                d.boxMin[0] = unity_SpecCube0_BoxMin;
                d.probePosition[0] = unity_SpecCube0_ProbePosition;
                d.probeHDR[0] = unity_SpecCube0_HDR;
                d.boxMax[1] = unity_SpecCube1_BoxMax;
                d.boxMin[1] = unity_SpecCube1_BoxMin;
                d.probePosition[1] = unity_SpecCube1_ProbePosition;
                d.probeHDR[1] = unity_SpecCube1_HDR;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float LdotH = max(0.0,dot(lightDirection, halfDirection));
                float3 diffuseColor = _Color.rgb; // Need this for specular when using metallic
                float specularMonochrome;
                float3 specularColor;
                float node_2140 = 0.0;
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, node_2140, specularColor, specularMonochrome );
                specularMonochrome = 1-specularMonochrome;
                float NdotV = max(0.0,dot( normalDirection, viewDirection ));
                float NdotH = max(0.0,dot( normalDirection, halfDirection ));
                float VdotH = max(0.0,dot( viewDirection, halfDirection ));
                float visTerm = SmithBeckmannVisibilityTerm( NdotL, NdotV, 1.0-gloss );
                float normTerm = max(0.0, NDFBlinnPhongNormalizedTerm(NdotH, RoughnessToSpecPower(1.0-gloss)));
                float specularPBL = max(0, (NdotL*visTerm*normTerm) * (UNITY_PI / 4) );
                float3 directSpecular = 1 * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularPBL*lightColor*FresnelTerm(specularColor, LdotH);
                half grazingTerm = saturate( gloss + specularMonochrome );
                float3 indirectSpecular = (gi.indirect.specular);
                indirectSpecular *= FresnelLerp (specularColor, grazingTerm, NdotV);
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float3 directDiffuse = ((1 +(fd90 - 1)*pow((1.00001-NdotL), 5)) * (1 + (fd90 - 1)*pow((1.00001-NdotV), 5)) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += gi.indirect.diffuse;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float node_8614 = pow(1.0-max(0,dot(normalDirection, viewDirection)),_FresnelOpacity);
                float3 node_4915 = (_Color.rgb*node_8614);
                float2 node_5235 = (i.uv0*_MainPatternTiling);
                float4 _MainPattern_var = tex2D(_MainPattern,TRANSFORM_TEX(node_5235, _MainPattern));
                float node_9402 = (1.0 - _MainPattern_var.r);
                float2 node_1683 = (i.uv0*_TranslucencyPatternTiling).rg;
                float4 node_8187 = _Time + _TimeEditor;
                float2 node_5162 = float2((node_1683.r+(_TranslucencyPatternSpeedX*node_8187.b)),(node_1683.g+(node_8187.b*_TranslucencyPatternSpeedY)));
                float4 _TranslucencyPattern_var = tex2D(_TranslucencyPattern,TRANSFORM_TEX(node_5162, _TranslucencyPattern));
                float3 emissive = lerp( node_4915, (1.0-(1.0-node_4915)*(1.0-((_Color.rgb*node_9402)*step(_TranslucencyPattern_var.r,0.999)))), _AddTranslucencyPatternEmission );
/// Final Color:
                float3 finalColor = diffuse * (node_8614+lerp( node_2140, node_9402, _AddedFresnel )) + specular + emissive;
                fixed4 finalRGBA = fixed4(finalColor,(node_8614+lerp( node_2140, node_9402, _AddedFresnel )));
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            Cull Front
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform float _FresnelOpacity;
            uniform sampler2D _MainPattern; uniform float4 _MainPattern_ST;
            uniform float _MainPatternTiling;
            uniform sampler2D _TranslucencyPattern; uniform float4 _TranslucencyPattern_ST;
            uniform float _TranslucencyPatternSpeedX;
            uniform float _TranslucencyPatternSpeedY;
            uniform float _TranslucencyPatternTiling;
            uniform fixed _AddTranslucencyPatternEmission;
            uniform fixed _AddedFresnel;
            uniform float _Reflectivity;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                LIGHTING_COORDS(7,8)
                UNITY_FOG_COORDS(9)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(-v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = 1.0 - (1.0 - _Reflectivity); // Convert roughness to gloss
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float LdotH = max(0.0,dot(lightDirection, halfDirection));
                float3 diffuseColor = _Color.rgb; // Need this for specular when using metallic
                float specularMonochrome;
                float3 specularColor;
                float node_2140 = 0.0;
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, node_2140, specularColor, specularMonochrome );
                specularMonochrome = 1-specularMonochrome;
                float NdotV = max(0.0,dot( normalDirection, viewDirection ));
                float NdotH = max(0.0,dot( normalDirection, halfDirection ));
                float VdotH = max(0.0,dot( viewDirection, halfDirection ));
                float visTerm = SmithBeckmannVisibilityTerm( NdotL, NdotV, 1.0-gloss );
                float normTerm = max(0.0, NDFBlinnPhongNormalizedTerm(NdotH, RoughnessToSpecPower(1.0-gloss)));
                float specularPBL = max(0, (NdotL*visTerm*normTerm) * (UNITY_PI / 4) );
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularPBL*lightColor*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float3 directDiffuse = ((1 +(fd90 - 1)*pow((1.00001-NdotL), 5)) * (1 + (fd90 - 1)*pow((1.00001-NdotV), 5)) * NdotL) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float node_8614 = pow(1.0-max(0,dot(normalDirection, viewDirection)),_FresnelOpacity);
                float2 node_5235 = (i.uv0*_MainPatternTiling);
                float4 _MainPattern_var = tex2D(_MainPattern,TRANSFORM_TEX(node_5235, _MainPattern));
                float node_9402 = (1.0 - _MainPattern_var.r);
                float3 finalColor = diffuse * (node_8614+lerp( node_2140, node_9402, _AddedFresnel )) + specular;
                fixed4 finalRGBA = fixed4(finalColor,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
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
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform float _FresnelOpacity;
            uniform sampler2D _MainPattern; uniform float4 _MainPattern_ST;
            uniform float _MainPatternTiling;
            uniform sampler2D _TranslucencyPattern; uniform float4 _TranslucencyPattern_ST;
            uniform float _TranslucencyPatternSpeedX;
            uniform float _TranslucencyPatternSpeedY;
            uniform float _TranslucencyPatternTiling;
            uniform fixed _AddTranslucencyPatternEmission;
            uniform float _Reflectivity;
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
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(-v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i) : SV_Target {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                float node_8614 = pow(1.0-max(0,dot(normalDirection, viewDirection)),_FresnelOpacity);
                float3 node_4915 = (_Color.rgb*node_8614);
                float2 node_5235 = (i.uv0*_MainPatternTiling);
                float4 _MainPattern_var = tex2D(_MainPattern,TRANSFORM_TEX(node_5235, _MainPattern));
                float node_9402 = (1.0 - _MainPattern_var.r);
                float2 node_1683 = (i.uv0*_TranslucencyPatternTiling).rg;
                float4 node_8187 = _Time + _TimeEditor;
                float2 node_5162 = float2((node_1683.r+(_TranslucencyPatternSpeedX*node_8187.b)),(node_1683.g+(node_8187.b*_TranslucencyPatternSpeedY)));
                float4 _TranslucencyPattern_var = tex2D(_TranslucencyPattern,TRANSFORM_TEX(node_5162, _TranslucencyPattern));
                o.Emission = lerp( node_4915, (1.0-(1.0-node_4915)*(1.0-((_Color.rgb*node_9402)*step(_TranslucencyPattern_var.r,0.999)))), _AddTranslucencyPatternEmission );
                
                float3 diffColor = _Color.rgb;
                float specularMonochrome;
                float3 specColor;
                float node_2140 = 0.0;
                diffColor = DiffuseAndSpecularFromMetallic( diffColor, node_2140, specColor, specularMonochrome );
                float roughness = (1.0 - _Reflectivity);
                o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
