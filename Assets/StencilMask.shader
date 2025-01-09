Shader "Unlit/StencilMask"
{
    Properties
    {
        [IntRange] _stencilID ("stencil ID" , Range(0,255)) = 0
    }
    SubShader
    {
        Tags {
            "RenderType"="Opaque"
            "Queue" = "Geometry"
            "RenderPipeline" = "UniversalPipeline"
        }
        

        Pass
        {
            Blend Zero One
            ZWrite Off

            Stencil
            {
                Ref [_stencilID]
                Comp Always
                Pass Replace
                Fail Keep
            }
            
         
        }
    }
}
