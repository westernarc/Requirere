using UnityEngine;
using System.Collections;
using System.Collections.Generic;

class SysLog : MonoBehaviour
{
    public static void Log(string content)
    {
        if (SysRef._ref.isDebug)
        {
            Debug.Log(content);
        }
    }
}
