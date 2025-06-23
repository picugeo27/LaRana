using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    private IState currentState;
    public PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        SwitchState(new PauseMenuState());   
    }

    // Update is called once per frame
    void Update()
    {
        currentState?.ChangeState();
    }

    public void SwitchState(IState newState)
    {
        currentState?.ExitState();
        currentState = newState;

        if (newState is PlayingState)
        {
            playerController.EnableControl(true);
        }
        else
        {
            playerController.EnableControl(false);
        }
        currentState.EnterState();
    }
}
