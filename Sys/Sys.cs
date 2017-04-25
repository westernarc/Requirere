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
        //Get all references
        SysRef._ref.Initialize();
        SysRef._ref.UiRef.Initialize();

        SysRef._ref.sysState.Initialize();
        
        
        
    }
    void Update()
    {

    }
}
