using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuState : IState
{
    public void EnterState()
    {
        Time.timeScale = 0f;
        SetCursorState(true, CursorLockMode.None);
    }

    public void ChangeState()
    {
        
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
