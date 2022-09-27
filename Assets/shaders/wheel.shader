Shader "Unlit/wheel"
{
    Properties
    {
        width("width",Range(0,0.5))=0.1
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            float width;

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct Interpolator
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            Interpolator vert (appdata v)
            {
                Interpolator o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }
            
            float4 frag (Interpolator i) : SV_Target
            {
                float bor=distance(float2(0.5,0.5),i.uv)-0.5;
                bor=1-step(0,bor);
                clip(bor-0.0001);
                float edge=distance(float2(0.5,0.5),i.uv)-0.45;
                edge=step(0,edge);
                float dis=distance(float2(0.5,i.uv.y),i.uv)-width;
                dis*=distance(float2(i.uv.x,0.5),i.uv)-width;
                dis*=distance(float2(i.uv.x,i.uv.x),i.uv)-width*1.3;
                dis*=distance(float2(1-i.uv.y,i.uv.y),i.uv)-width*1.3;
                dis=1-step(0,dis);
                float4 col=lerp(float4(dis.xxx,1),float4(edge.xxx,1),edge);
                clip(col-0.0001);
                return col;
            }
            ENDCG
        }
    }
}
