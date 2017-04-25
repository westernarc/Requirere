using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SysRef : TemplateRef
{
    protected static SysRef __ref;
    public static SysRef _ref
    {
        get
        {
            if (__ref == null)
            {
                __ref = GameObject.FindObjectOfType<SysRef>();
            }
            return __ref;
        }
    }
    public bool isDebug;

    public SysState sysState;
    public SysClock sysClock;

    public UiRef UiRef;

    public void Initialize()
    {
        BindReferences();
    }

    public void BindReferences()
    {
        SysLog.Log("SysRef.BindReferences");
        UiRef = GameObject.FindObjectOfType<UiRef>();

        sysState = GameObject.FindObjectOfType<SysState>();
        sysClock = GameObject.FindObjectOfType<SysClock>();
    }

    
}
