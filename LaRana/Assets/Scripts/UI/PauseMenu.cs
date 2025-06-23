using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void Resume()
    {

    }

    public void ToMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
        Debug.Log("HAS APRETADO EL BOTON");
    }
}
