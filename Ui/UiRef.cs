using UnityEngine;
using System.Collections;

public class UiRef : TemplateRef
{
    protected static UiRef __ref;
    public static UiRef _ref
    {
        get
        {
            if (__ref == null)
            {
                __ref = GameObject.FindObjectOfType<UiRef>();
            }
            return __ref;
        }
    }

    public UiTransition transition;

	// Use this for initialization
	public void Initialize() {
        SysLog.Log("UiRef.Initialize");
        BindReferences();
	}
    public void BindReferences()
    {
        transition = GameObject.FindObjectOfType<UiTransition>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
