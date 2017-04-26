using UnityEngine;
using UnityEngine.UI;
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
    public Texture2D uiTransitionTexture;
    public Image uiTransitionImage;

	// Use this for initialization
	public void Initialize() {
        SysLog.Log("UiRef.Initialize");
        BindReferences();

        transition.Initialize();
	}
    public void BindReferences()
    {
        transition = GameObject.FindObjectOfType<UiTransition>();
        uiTransitionImage = GameObject.Find("UiTransitionImage").GetComponent<Image>();
    }
	
	// Update is called once per frame
	public void Run() {
        UiRef._ref.transition.Run();
	}
}
