
# urp控制ColorLut来屏幕灰化

## 效果



## 代码

```cs

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

```

