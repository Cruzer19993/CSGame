using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehavior{
    public string testMessage;

    public void LogMessage(string message){
        Debug.log(message);
    }

    public void Start(){
        LogMessage(testMessage);
    }
}