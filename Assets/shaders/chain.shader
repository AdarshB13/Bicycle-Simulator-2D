Shader "Unlit/chain"
{
    Properties
    {
        edis("edis",Range(0,1))=0.2
        odis("odis",Range(0,1))=0.8
        blck("blck",Range(0,0.2))=0.1
        cdis("cdis",Range(0,1))=0.1
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

            float edis;
            float odis;
            float blck;
            float cdis;

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
                
                float dis=distance(float2(0.2,0.5),i.uv)-edis;
                dis*=distance(float2(0.8,0.5),i.uv)-odis;
                dis*=distance(float2(0.5,0.5),i.uv)+cdis;
                dis-=blck;
                clip(dis);
                dis=1-dis-0.99;
                clip(dis);
                float col=float4(1-dis.xxx,1);
                return col;
            }
            ENDCG
        }
    }
}
