using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPause : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            ServiceLocator.GetGameManager().PauseGame();
            Debug.Log(ServiceLocator.GetGameManager().IsPaused);
        }

    }
}
