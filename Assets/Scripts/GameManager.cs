using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : IGameManager
{
    private bool isPaused;
    public bool IsPaused => isPaused;

    public void PauseGame()
    {
        isPaused = !isPaused;
    }

}
