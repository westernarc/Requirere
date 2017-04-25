using UnityEngine;
using System.Collections;

public abstract class TemplateState : MonoBehaviour
{
    public abstract void Initialize();
    public abstract void Run();
    public abstract void Cleanup();
}
