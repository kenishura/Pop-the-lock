using UnityEngine;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{
    public int remainingDots = 10;
    TextMeshProUGUI _text;

    public void DecrementDots()
    {
        remainingDots--;
        if(remainingDots < 0)
        {
            remainingDots = 0;
        }
    }
    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        _text.text = remainingDots.ToString();
    }

}
