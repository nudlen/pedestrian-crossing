using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HumanType
{
    public string Genger = "man";
    public string Age = "young";
    public bool isSnowed = false;
    public string waitingTime = "short";
}


public class ReceiveMessage : MonoBehaviour
{

    HumanType human = new HumanType();
    
    public void receiveMessage(string info)
    {
        if (info == "man" || info == "woman")
        {
            human.Genger = info;
        }
        else if(info == "young" || info == "middle" || info == "old")
        {
            human.Age = info;
        }
        else if(info == "snowy")
        {
            human.isSnowed = true;
        }
        else if (info == "sunny" || info == "rainy" || info == "foggy")
        {
            human.isSnowed = false;
        }
        else if (info == "short" || info == "moderate" || info == "long")
        {
            human.waitingTime = info;
        }
        

        //控制步速
        //非下雪天
        if(human.Genger == "man" && !human.isSnowed)
        {
            if(human.Age == "young") // 男青年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 1.4f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").transform.position = new Vector3(536.0f, 0.26f, 452-60);
                    GameObject.FindGameObjectWithTag("Canvas").transform.position = new Vector3(536.0f, 1.8f, 452 - 60+4);
                    
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").transform.position = new Vector3(536, 0.26f, 452 - 65);
                    GameObject.FindGameObjectWithTag("Canvas").transform.position = new Vector3(536, 1.8f, 452 - 65 + 4);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 90);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 90 + 4);
                }
            }
            else if(human.Age == "middle") //男中年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 1.2f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 45);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 45 + 4);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 45);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 45 + 4);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 70);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 70 + 4);
                }
            }
            else // 男老年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 1.0f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 30);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 30 + 4);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 32);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 32 + 4);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 46);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 46 + 4);
                }
            }
        }
        else if (human.Genger == "woman" && !human.isSnowed)
        {
            if (human.Age == "young") //女青年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 1.3f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 55);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 55 + 4);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 60);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 60 + 4);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 90);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 90 + 4);
                }
            }
            else if (human.Age == "middle") // 女中年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 1.1f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 34);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 34 + 4);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 37);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 37 + 4);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 52);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 52 + 4);
                }
            }
            else // 女老年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 0.9f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 26);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 26 + 4);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 28);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 28 + 4);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 40);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 40 + 4);
                }
            }
        }

        //下雪天
        else if (human.Genger == "man" && human.isSnowed)
        {
            if (human.Age == "young") // 男青年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 1.1f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 47);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 47 + 4);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 50);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 50 + 4);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 75);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 75 + 4);
                }
            }
            else if (human.Age == "middle") // 男中年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 0.8f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 32);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 32 + 4);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 36);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 36 + 4);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 55);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 55 + 4);
                }
            }
            else // 男老年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 0.6f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 26);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 26 + 4);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 28);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 28 + 4);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 40);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 40 + 4);
                }
            }
        }
        else if (human.Genger == "woman" && human.isSnowed)
        {
            if (human.Age == "young") // 女青年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 1.0f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 42);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 42 + 4);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 45);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 45 + 4);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 70);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 70 + 4);
                }
            }
            else if (human.Age == "middle") // 女中年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 0.7f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 30);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 30 + 4);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 32);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 32 + 4);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 46);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 46 + 4);
                }
            }
            else // 女老年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 0.5f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 22);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 22 + 4);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 24);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 24 + 4);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(536, 0.26f, 452 - 35);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(536, 1.8f, 452 - 35 + 4);
                }
            }
        }
    }
}
