using UnityEngine;

[CreateAssetMenu]
public class GameData : ScriptableObject
{
    public int currentLevel;
    public int dotsRemaining;
    public int stars;

    public bool isRunning = false;

    public void ResetLevel()
    {
        isRunning = false;
        dotsRemaining = currentLevel;
    }

    public void ResetData()
    {
        currentLevel = 1;
        dotsRemaining = currentLevel;
    }


}
