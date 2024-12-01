using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class GetButtonPress : MonoBehaviour // 本类用于实时获取Grip键按压以及加速运动
{
    private InputDevice _targetDevice;
    HumanType human = new HumanType();
    public float activateSpeed = 2.0f;
    public float normalSpeed = 1.4f;

    public void receiveMessageInButtonPress(string info)
    {

        if (info == "man" || info == "woman")
        {
            human.Genger = info;
        }
        else if (info == "young" || info == "middle" || info == "old")
        {
            human.Age = info;
        }
        else if (info == "snowy")
        {
            human.isSnowed = true;
        }
        else if (info == "sunny" || info == "rainy" || info == "foggy")
        {
            human.isSnowed = false;
        }

        if (human.Genger == "man" && !human.isSnowed)
        {
            if (human.Age == "young")
            {
                activateSpeed = 2.0f;
                normalSpeed = 1.4f;
            }
            else if (human.Age == "middle")
            {
                activateSpeed = 1.5f;
                normalSpeed = 1.2f;
            }
            else
            {
                activateSpeed = 1.2f;
                normalSpeed = 1.0f;
            }

        }
        else if (human.Genger == "woman" && !human.isSnowed)
        {
            if (human.Age == "young")
            {
                activateSpeed = 1.8f;
                normalSpeed = 1.3f;
            }
            else if (human.Age == "middle")
            {
                activateSpeed = 1.4f;
                normalSpeed = 1.1f;
            }
            else
            {
                activateSpeed = 1.2f;
                normalSpeed = 0.9f;
            }
        }
        else if (human.Genger == "man" && human.isSnowed)
        {
            if (human.Age == "young")
            {
                activateSpeed = 1.4f;
                normalSpeed = 1.1f;
            }
            else if (human.Age == "middle")
            {
                activateSpeed = 1.0f;
                normalSpeed = 0.8f;
            }
            else
            {
                activateSpeed = 0.7f;
                normalSpeed = 0.6f;
            }
        }
        else if (human.Genger == "woman" && human.isSnowed)
        {
            if (human.Age == "young")
            {
                activateSpeed = 1.3f;
                normalSpeed = 1.0f;
            }
            else if (human.Age == "middle")
            {
                activateSpeed = 0.8f;
                normalSpeed = 0.7f;
            }
            else
            {
                activateSpeed = 0.6f;
                normalSpeed = 0.5f;
            }
        }
    }

    void Start()
    {
        TryInitialize();
    }

    void TryInitialize()
    {
        var inputDevices = new List<InputDevice>();
        InputDeviceCharacteristics rightControllerCharacteristics =
            InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, inputDevices);

        if (inputDevices.Count == 0)
        {
            return;
        }

        _targetDevice = inputDevices[0];
    }

    void Update()
    {
        if (!_targetDevice.isValid)
        {
            TryInitialize();
        }
        else
        {
            _targetDevice.TryGetFeatureValue(CommonUsages.gripButton, out bool gripButtonValue);
            if(gripButtonValue == true)
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = activateSpeed;

            }
            else
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = normalSpeed;
            }
            
        }
    }
}
