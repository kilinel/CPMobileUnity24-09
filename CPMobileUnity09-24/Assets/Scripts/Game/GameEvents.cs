using System;

public static class GameEvents
{
    public static event Action selosColetado;
    public static event Action playerMorreu;
    public static void OnSeloCollected()
    {
        selosColetado?.Invoke();
    }

    public static void OnPlayerDied()
    {
        playerMorreu?.Invoke();
    }
}