using UnityEngine;

[CreateAssetMenu]
public class GameData : ScriptableObject
{
    public int currentLevel;
    public int maxUnlockedLevel;
    public int dotsRemaining;
    public int stars;

    public void ResetLevel()
    {
        dotsRemaining = currentLevel;
    }

}
