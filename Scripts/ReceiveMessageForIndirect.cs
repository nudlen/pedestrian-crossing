using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ReceiveMessageForIndirect : MonoBehaviour
{
    HumanType human = new HumanType();

    public void receiveMessage(string info)
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
        else if (info == "sunny" || info == "rainy")
        {
            human.isSnowed = false;
        }
        else if (info == "short" || info == "moderate" || info == "long")
        {
            human.waitingTime = info;
        }


        //控制步速
        //非下雪天
        if (human.Genger == "man" && !human.isSnowed)
        {
            if (human.Age == "young") // 男青年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 1.4f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").transform.position = new Vector3(538.0f - 52, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").transform.position = new Vector3(538.0f - 52 + 4, 1.8f, 450.0f);

                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").transform.position = new Vector3(538.0f - 55, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").transform.position = new Vector3(538.0f - 55 + 4, 1.8f, 450.0f);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 90, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 90 + 4, 1.8f, 450.0f);
                }
            }
            else if (human.Age == "middle") //男中年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 1.2f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 38, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 38 + 4, 1.8f, 450.0f);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 40, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 40 + 4, 1.8f, 450.0f);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 65, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 65 + 4, 1.8f, 450.0f);
                }
            }
            else // 男老年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 1.0f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 26, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 26 + 4, 1.8f, 450.0f);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 28, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 28 + 4, 1.8f, 450.0f);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 46, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 46 + 4, 1.8f, 450.0f);
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
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 47, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 47 + 4, 1.8f, 450.0f);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 52, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 52 + 4, 1.8f, 450.0f);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 85, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 85 + 4, 1.8f, 450.0f);
                }
            }
            else if (human.Age == "middle") // 女中年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 1.1f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 30, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 30 + 4, 1.8f, 450.0f);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 32, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 32 + 4, 1.8f, 450.0f);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 52, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 52 + 4, 1.8f, 450.0f);
                }
            }
            else // 女老年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 0.9f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 24, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 24 + 4, 1.8f, 450.0f);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 25, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 25 + 4, 1.8f, 450.0f);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 39, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 39 + 4, 1.8f, 450.0f);
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
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 40, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 40 + 4, 1.8f, 450.0f);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 45, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 45 + 4, 1.8f, 450.0f);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 70, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 70 + 4, 1.8f, 450.0f);
                }
            }
            else if (human.Age == "middle") // 男中年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 0.8f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 30, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 30 + 4, 1.8f, 450.0f);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 33, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 33 + 4, 1.8f, 450.0f);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 52, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 52 + 4, 1.8f, 450.0f);
                }
            }
            else // 男老年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 0.6f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 23, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 23 + 4, 1.8f, 450.0f);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 25, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 25 + 4, 1.8f, 450.0f);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 39, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 39 + 4, 1.8f, 450.0f);
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
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 37, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 37+4, 1.8f, 450.0f);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 40, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 40 + 4, 1.8f, 450.0f);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 65, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 65 + 4, 1.8f, 450.0f);
                }
            }
            else if (human.Age == "middle") // 女中年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 0.7f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 26, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 26 + 4, 1.8f, 450.0f);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 29, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 29 + 4, 1.8f, 450.0f);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 46, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 46 + 4, 1.8f, 450.0f);
                }
            }
            else // 女老年
            {
                GameObject.FindGameObjectWithTag("VROrigin").GetComponent<ActionBasedContinuousMoveProvider>().moveSpeed = 0.5f;
                if (human.waitingTime == "short")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 19, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 19 + 4, 1.8f, 450.0f);
                }
                else if (human.waitingTime == "moderate")
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 21, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 21 + 4, 1.8f, 450.0f);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("VROrigin").GetComponent<Transform>().position = new Vector3(538.0f - 33, 0.26f, 450.0f);
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<Transform>().position = new Vector3(538.0f - 33 + 4, 1.8f, 450.0f);
                }
            }
        }
    }
}
