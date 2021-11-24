using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDelegate : MonoBehaviour
{
    //创建一个实例
    public delegate void DebugString(string param);

    //输出中文名字
    public void DebugChineseName(string str)
    {
        Debug.Log("中文名字:  " + str);
    }

    // 输出英文名字
    public void DebugNameOfEnglish(string str)
    {
        Debug.Log("English Name:  " + str);
    }

    //定义一个委托的变量事件
    public DebugString handlerDebugString;

    void OnGUI()
    {
        if (GUILayout.Button("输出中文名字"))
        {
            handlerDebugString = DebugChineseName;
            handlerDebugString("张三");
        }
        else if (GUILayout.Button("Debug English Name"))
        {
            handlerDebugString = DebugNameOfEnglish;
            handlerDebugString("Jack");
        }
    }
}


