using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[ExecuteInEditMode]
public class UrpSceneGray : MonoBehaviour
{
    bool m_Gray = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchEff()
    {
        Volume volume = GetComponent<Volume>();
        if (volume == null)
            return;

        ColorAdjustments colorAdjust = null;
        volume.sharedProfile.TryGet<ColorAdjustments>(out colorAdjust);
        if (colorAdjust == null)
            return;

        m_Gray = !m_Gray;

        if (m_Gray)
        {
            colorAdjust.postExposure.value = -0.1f;
            colorAdjust.contrast.value = 40;
            colorAdjust.hueShift.value = 0;
            colorAdjust.saturation.value = -100;
        }
        else
        {
            colorAdjust.postExposure.value = 0;
            colorAdjust.contrast.value = 0;
            colorAdjust.hueShift.value = 0;
            colorAdjust.saturation.value = 0;
        }

        
    }
}
