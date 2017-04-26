using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UiTransition : MonoBehaviour {
    /*Controls UI Fading in and out*/
    public float alpha;
    public float startAlpha;
    public float targetAlpha;

    public Color color;
    private Texture2D texture;
    private Image image;

	// Use this for initialization
	public void Initialize () {
        texture = UiRef._ref.uiTransitionTexture;
        image = UiRef._ref.uiTransitionImage;
	}
	
	// Update is called once per frame
	public void Run () {
        color.a = alpha;
        image.color = color;
	}
    public void Fade()
    {
        startAlpha = 0;
        targetAlpha = 1;
        if (alpha != targetAlpha && alpha == startAlpha) {
            StartCoroutine("_Fade");
        }
    }
    public IEnumerator _Fade()
    {
        //SysLog.Log("UiTransition._Fade");
        while (alpha < 1) {
            SysLog.Log("UiTransition._Fade:" + alpha + " : " + SysRef._ref.sysClock.step);
            alpha += SysRef._ref.sysClock.step;
            alpha = Mathf.Min(alpha, 1);
            yield return null;
        }
    }
    public void Unfade()
    {
        SysLog.Log("UiTransition.Unfade");
        targetAlpha = 0;
        if (alpha != targetAlpha)
        {
            StartCoroutine("_Unfade");
        }
    }
    public IEnumerator _Unfade()
    {
        while (alpha > 0)
        {
            alpha -= SysRef._ref.sysClock.step;
            alpha = Mathf.Max(alpha, 0);
            yield return null;
        }
    }
}
