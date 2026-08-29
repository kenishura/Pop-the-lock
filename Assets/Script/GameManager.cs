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
        if (_didTap && gameData.isRunning == false && isFirstTap)
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

    public void LoadLevel(bool isNextLevel)
    {
        if (isNextLevel) gameData.currentLevel++;

        gameData.ResetLevel();
        isFirstTap = true;

    }

    public void Stop()
    {
        gameData.isRunning = false;
    }

    public bool _didTap
    {
        get
        {
            return Input.GetMouseButtonDown(0);
        }
    }
}
