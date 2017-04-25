using UnityEngine;
using System.Collections;

public class SysState : MonoBehaviour
{
    //Tracks what state the game is in.

    public enum STATE
    {
        Title, Game, Score
    }
    public STATE state;

    public SysStateTitle title;
    public SysStateGame game;
    public SysStateScore score;

    // Use this for initialization
    public void Initialize()
    {
        SysLog.Log("SysState.Initialize");
    }

    // Update is called once per frame
    public void Run()
    {
        
    }

    public void SwitchState(STATE nextState)
    {
        //Need to start transition out.
        //When transition is complete, switch state 
    }
}
