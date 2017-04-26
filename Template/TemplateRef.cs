using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TemplateRef : MonoBehaviour
{
    protected static TemplateRef __ref;
    public static TemplateRef _ref
    {
        get
        {
            if (__ref == null)
            {
                __ref = GameObject.FindObjectOfType<TemplateRef>();
            }
            return __ref;
        }
    }
}

