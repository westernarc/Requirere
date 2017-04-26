using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*
 * Game Main Class
 *
*/
class Sys : MonoBehaviour
{
    void Awake()
    {
        SysLog.Log("Sys.Awake");
        //Get all references
        SysRef._ref.Initialize();
        SysRef._ref.UiRef.Initialize();

        SysRef._ref.sysState.Initialize();
        
        
        
    }
    void Update()
    {
        //SysLog.Log("Sys.Update");
        SysRef._ref.UiRef.Run();
        SysRef._ref.UiRef.transition.Fade();
    }
}
