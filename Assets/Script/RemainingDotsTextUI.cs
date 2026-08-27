using TMPro;
using UnityEngine;

public class RemainingDotsTextUI : MonoBehaviour
{
    TextMeshProUGUI text;
    public GameData gameData;

    public void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.text = gameData.dotsRemaining.ToString();
    }

    private void Update()
    {
        text.text = gameData.dotsRemaining.ToString();
    }

}
