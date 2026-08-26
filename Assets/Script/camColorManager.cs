using UnityEngine;

public class camColorManager : MonoBehaviour
{
    Camera cam;
    public Color loseColor;
    Color mainColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = GetComponent<Camera>();
        mainColor = cam.backgroundColor;

    }

    public void SwitchToLoseColor()
    {
        cam.backgroundColor = loseColor;
    }

    public void SwitchToMainColor()
    {
        cam.backgroundColor = mainColor;
    }
}
