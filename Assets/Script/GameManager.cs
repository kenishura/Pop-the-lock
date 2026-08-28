using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameData gameData;
    public GameEvent winEvent;
    bool isFirstTap = true;

    public void Start()
    {
        gameData.ResetLevel();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && gameData.isRunning == false && isFirstTap)
        { 
            gameData.isRunning = true;
            isFirstTap = false;
        }
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
    public void Stop()
    {
        gameData.isRunning = false;
    }
}
