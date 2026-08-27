using TMPro;
using UnityEngine;

public class StarTextUI : MonoBehaviour
{
    TextMeshProUGUI text;
    public GameData gameData;

    public void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.text = "Stars: " + gameData.stars.ToString();
    }

    private void Update()
    {
        text.text = "Stars: " + gameData.stars.ToString();
    }

}

