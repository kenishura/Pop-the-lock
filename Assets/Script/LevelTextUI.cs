using UnityEngine;
using TMPro;

public class LevelTextUI : MonoBehaviour
{
    TextMeshProUGUI text;
    public GameData gameData;

    public void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.text = "Level: " + gameData.currentLevel.ToString();
    }

    private void Update()
    {
        text.text = "Level: " + gameData.currentLevel.ToString();
    }

}
