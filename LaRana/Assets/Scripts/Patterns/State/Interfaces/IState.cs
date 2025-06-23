using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    void EnterState();
    void ChangeState();
    void ExitState();

    void SetCursorState(bool visible, CursorLockMode lockMode);

}
