Shader "Unlit/hub"
{
    Properties
    {

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

            fixed4 frag (Interpolator i) : SV_Target
            {
                float dis=distance(float2(0.5,0.5),i.uv)-0.5;
                dis=1-step(0,dis);
                clip(dis-0.0001);
                float indis=distance(float2(0.5,0.5),i.uv)-0.4;
                indis=step(0,indis);
                float rid=distance(float2(0.5,0.5),i.uv)-0.25;
                clip(rid);
                return float4(indis.xxx,1);
            }
            ENDCG
        }
    }
}
