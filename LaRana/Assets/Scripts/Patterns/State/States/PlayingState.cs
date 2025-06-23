using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingState : IState
{
    public void EnterState()
    {
        Time.timeScale = 1.0f;
        SetCursorState(false, CursorLockMode.Locked);
    }

    public void ChangeState()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
        }
    }

    public void ExitState()
    {

    }
    public void SetCursorState(bool visible, CursorLockMode mode)
    {
        Cursor.visible = visible;
        Cursor.lockState = mode;
    }

}
