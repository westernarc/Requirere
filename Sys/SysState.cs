using UnityEngine;
using System.Collections;

public class SysState : MonoBehaviour
{
    //Tracks what state the game is in.

    public enum STATE
    {
        Title, Game, Score
    }
    public STATE stateCurrent;
    public STATE stateNext;

    public SysStateTitle title;
    public SysStateGame game;
    public SysStateScore score;

    // Use this for initialization
    public void Initialize()
    {
        SysLog.Log("SysState.Initialize");
        stateCurrent = STATE.Title;
    }

    // Update is called once per frame
    public void Run()
    {
        switch (stateCurrent)
        {
            case STATE.Title:
                title.Run();
                break;
            case STATE.Game:
                game.Run();
                break;
            case STATE.Score:
                title.Run();
                break;
        }
    }

    public void SwitchState(STATE nextState)
    {
        //Need to start transition out.
        //When transition is complete, switch state 
        stateNext = nextState;
    }
}
