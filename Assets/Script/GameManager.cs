using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameData gameData;
    public GameEvent winEvent;

    public void Start()
    {
        gameData.ResetLevel();
    }

    public void DecrementRemainingDots()
    {
        gameData.dotsRemaining--;
        if(gameData.dotsRemaining <= 0)
        {
            gameData.dotsRemaining = 0;
            winEvent.Raise();
        }
    }

    public void LoadNextLevel()
    {
        gameData.currentLevel++;
        gameData.ResetLevel();
      
    }

}
