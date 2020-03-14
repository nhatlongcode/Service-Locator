using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class ServiceLocator
{
    //everything in this class will be static
    static IGameManager gameManager;
    static NullGameManager nullGameManager;

    public static void Init()
    {
        gameManager = nullGameManager;
    }

    public static void ProvideGameManager(IGameManager newGameManager)
    {
        gameManager = newGameManager;
    }

    public static IGameManager GetGameManager()
    {
        return gameManager;
    }
}
