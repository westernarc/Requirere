using UnityEngine;
using System.Collections;

public abstract class TemplateState : MonoBehaviour
{
    public bool isTerminating;
    public bool isTerminated;
    public abstract void Initialize();
    public abstract void Run();
    public abstract void Terminate();
}
