using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkybox : MonoBehaviour
{
    public void UpdateSkybox(Material newSkybox)
    {
        RenderSettings.skybox = newSkybox;
    }
}
