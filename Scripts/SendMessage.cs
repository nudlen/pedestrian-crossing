using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendMessage : MonoBehaviour
{
    public void sendMessage(string StringUWantToSend)
    {
        GameObject.FindGameObjectWithTag("ReceiveTag").SendMessage("receiveMessage", StringUWantToSend);
        GameObject.FindGameObjectWithTag("GetPosition").SendMessage("receiveMessageInPosition", StringUWantToSend);
        GameObject.FindGameObjectWithTag("GetButtonPress").SendMessage("receiveMessageInButtonPress", StringUWantToSend);
    }
}
