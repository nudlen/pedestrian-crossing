using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class GetPositionForTest : MonoBehaviour
{
    public void onClick() // 点击以后启动实时获取位置
    {
        StartCoroutine(getPosition());
        PositionData.sceneName = SceneManager.GetActiveScene().name;
    }
    // 声明位置类
    [System.Serializable] //序列化，只有加上这个特性，类里面的数据才能正常的转成Json数据
    class Position
    {
        public float x;
        public float z;
        public Vector3 rotate;
    }
    // 声明数据类
    [System.Serializable]
    class Data
    {
        public string sceneName;
        public string weather = "sunny";
        public string gender = "man";
        public string age = "young";
        public string waitingTime = "short";
        public bool isCrashed;
        public List<Position> positionList;
    }
    private InputDevice _targetDevice; // 获取头戴式设备
    Quaternion rotation; // 四元数
    Vector3 oular;  // 欧拉角
    float xx;
    float zz;
    string json;
    string fileUrl;
    /*float angle;*/



    Data PositionData = new Data(); //实例化数据类
    DateTime dt = DateTime.Now; // 实例化日期时间

    void Start()
    {
        TryInitialize(); //初始化头戴式设备
    }
    void TryInitialize()
    {
        var inputDevices = new List<InputDevice>();
        InputDeviceCharacteristics headsetControllerCharacteristics = InputDeviceCharacteristics.HeadMounted;
        InputDevices.GetDevicesWithCharacteristics(headsetControllerCharacteristics, inputDevices);

        if (inputDevices.Count == 0)
        {
            return;
        }

        _targetDevice = inputDevices[0];
    }

    void Update()
    {
        if (!_targetDevice.isValid) // 用update重复初始化，因为Start里的初始化可能会失败
        {
            TryInitialize();

        }
        else
        {
            _targetDevice.TryGetFeatureValue(CommonUsages.deviceRotation, out rotation); // 根据特性获取头戴式设备旋转角，rotation为四元数
            oular = rotation.eulerAngles; // 四元数转换为欧拉角
        }
    }


    public void receiveMessageInPosition(string info)
    {
        Debug.Log("info: " + info);

        if (info == "man" || info == "woman")
        {
            PositionData.gender = info;
        }
        else if (info == "young" || info == "middle" || info == "old")
        {
            PositionData.age = info;
        }
        else if (info == "sunny" || info == "rainy" || info == "snowy")
        {
            PositionData.weather = info;
        }
        else if (info == "isCrashed")
        {
            PositionData.isCrashed = true;
        }
        else if (info == "short" || info == "moderate" || info == "long")
        {
            PositionData.waitingTime = info;
        }
    }

    IEnumerator getPosition()
    {
        PositionData.positionList = new List<Position>();
        while (true)
        {
            Position Position_x_y = new Position();
            xx = GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position.x;
            zz = GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position.z;
            /*angle = GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().localEulerAngles.y;*/
            // 获取旋转角
            Position_x_y.rotate = oular;
            Position_x_y.x = xx - 538;// 原点坐标在世界坐标系中是（X: 538，z: 450）
            Position_x_y.z = zz - 450;

            PositionData.positionList.Add(Position_x_y);
            json = JsonUtility.ToJson(PositionData);
            Debug.Log(json);
            Debug.Log(Time.timeSinceLevelLoad);
            yield return new WaitForSeconds(1.0f); // 位置读取间隔（浮点数）
        }

    }
    /*void OnApplicationPause() // 软件退出时，执行保存数据到json并存储在VR本地内存
    {
        fileUrl = Application.persistentDataPath + "/" + $"{dt.Year}{dt.Month}{dt.Day}{dt.Hour}{dt.Minute}{dt.Second}.json";
        Debug.Log(fileUrl);
        if (json != null) // 判空，如果是空数据则不存，排除还没开始行动就点击退出软件的情况
        {
            using (StreamWriter sw = new StreamWriter(fileUrl))
            {
                //保存数据
                sw.WriteLine(json);
                Debug.Log("Write in");
                Debug.Log("json: " + json);
                //关闭文档
                sw.Close();
                sw.Dispose();
            }
        }


    }*/
}
