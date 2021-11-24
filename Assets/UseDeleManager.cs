using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseDeleManager : MonoBehaviour
{
    void Start()
    {
        DeleManager.Instance.DebugNum += DebugNumOne;
    }

    public void DebugNumOne()
    {
        Debug.Log("1");
    }
}
