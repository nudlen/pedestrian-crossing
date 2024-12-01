using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoggySwitch : MonoBehaviour
{
    public void foggyOn()
    {
        RenderSettings.fog = true;
    }
    public void foggyOff()
    {
        RenderSettings.fog = false;
    }
}
