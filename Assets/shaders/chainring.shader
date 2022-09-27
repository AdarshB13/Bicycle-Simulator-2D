Shader "Unlit/chainring"
{
    Properties
    {
        width("width",Range(0,0.1))=0.01
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

            fixed4 frag (Interpolator i) : SV_Target
            {
                float bor=distance(float2(0.5,0.5),i.uv)-0.45;
                bor=step(0,bor);
                float dis=distance(float2(0.5,i.uv.y),i.uv);
                dis*=distance(float2(i.uv.x,0.5),i.uv);
                dis=step(dis-width,0);
                float4 col=lerp(float4(dis.xxx,1),float4(bor.xxx,1),bor);
                clip(col-0.0001);
                return col;
            }
            ENDCG
        }
    }
}
