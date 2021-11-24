using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleManager : MonoBehaviour
{
    static DeleManager instance;
    public static DeleManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<DeleManager>();
            }
            //if(instance==null)  //现在场景里没有GameManager实例
            //{
            //	GameObject obj = new GameObject();
            //	obj.AddComponent<DeleManager>();
            //	instance=obj.GetComponent<DeleManager>();
            //}
            return instance;
        }
    }

    public Action DebugNum;

    void OnGUI()
    {
        if (GUILayout.Button("输出数字"))
        {
            DebugNum();
        }
    }
}
