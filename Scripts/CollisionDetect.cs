using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    bool alreadyHit;
    string collisionName;
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (alreadyHit) // 已经撞了，退出碰撞检测
        {
            Debug.Log("已经撞了，碰撞检测结束");
            return;
        }
        else
        {
            if (hit.gameObject.name == collisionName) //不需要重复检测同一个物体的碰撞
            {
                return;
            }
            else
            {
                collisionName = hit.gameObject.name;
                // 车的名字
                if (hit.gameObject.transform.parent) // 判断是否有父对象，以免出现空对象赋值的bug
                {
                    if (hit.gameObject.transform.parent.name == "Bus_1A" || hit.gameObject.transform.parent.name == "Bus_2A" || hit.gameObject.transform.parent.name == "Compact_1A" ||
                   hit.gameObject.transform.parent.name == "Compact_1B" || hit.gameObject.transform.parent.name == "Compact_2A" || hit.gameObject.transform.parent.name == "Compact_2B" ||
                   hit.gameObject.transform.parent.name == "Compact_3A" || hit.gameObject.transform.parent.name == "Compact_4A" || hit.gameObject.transform.parent.name == "Coupe_1A" ||
                   hit.gameObject.transform.parent.name == "Coupe_1B" || hit.gameObject.transform.parent.name == "Coupe_2A" || hit.gameObject.transform.parent.name == "Hybrid_1A" ||
                   hit.gameObject.transform.parent.name == "Hybrid_1B" || hit.gameObject.transform.parent.name == "PickUp_1A" || hit.gameObject.transform.parent.name == "PickUp_3A_naked" ||
                   hit.gameObject.transform.parent.name == "PickUp_3B" || hit.gameObject.transform.parent.name == "Sedan_1A" || hit.gameObject.transform.parent.name == "Sedan_2A" ||
                   hit.gameObject.transform.parent.name == "Sedan_3A" || hit.gameObject.transform.parent.name == "Sedan_4A" || hit.gameObject.transform.parent.name == "Sedan_5A" ||
                   hit.gameObject.transform.parent.name == "Sedan_6B_naked" || hit.gameObject.transform.parent.name == "Supersport_1A" || hit.gameObject.transform.parent.name == "SUV_1A" ||
                   hit.gameObject.transform.parent.name == "Truck_1B" || hit.gameObject.transform.parent.name == "Van_1A" || hit.gameObject.transform.parent.name == "Van_2A")
                    {
                        GameObject.FindGameObjectWithTag("GetPosition").SendMessage("receiveMessageInPosition", "isCrashed"); // 发送信息到json保存
                        alreadyHit = true; // 设置为已碰撞状态
                        Debug.Log("撞了： " + hit.gameObject.transform.parent.name);
                    }
                }
                
                
            }
        }
        
    }
}
