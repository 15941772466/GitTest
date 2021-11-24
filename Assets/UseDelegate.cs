using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseDelegate : MonoBehaviour
{
    //TestDelegate del1 = new TestDelegate();

    //void Start()
    //{
    //    del1.DebugChineseName("张三");
    //    del1.handlerDebugString = del1.DebugChineseName;
    //    del1.handlerDebugString("张三");
    //}

    void Start()
    {
        DeleManager.Instance.DebugNum += DebugNumTwo;
    }

    public void DebugNumTwo()
    {
        Debug.Log("2");
    }
}
