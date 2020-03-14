using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameManager
{
    bool IsPaused { get; }

    void PauseGame();
}

