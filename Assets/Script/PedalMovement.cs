using UnityEngine;

public class PedalMovement : MonoBehaviour
{
    public GameData gameData;
    public Transform indicatorTransform;
    public Transform anchorTransform;
    public int rotationSpeed = 20;
    public Direction Direction = Direction.ClockWise;
    Vector3 initialPos;

    public void Start()
    {
        initialPos = indicatorTransform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameData.isRunning)
        {
            GameLoop();
        }

    }

    void GameLoop()
    {
        indicatorTransform.RotateAround(anchorTransform.position, Vector3.forward, rotationSpeed * Time.deltaTime * -(int)Direction);

        if (_didTap)
        {
            ChangeDirection();
        }
    }

    public bool _didTap
    {
        get
        {
            return Input.GetMouseButtonDown(0);
        }
    }

    void ChangeDirection()
    {
        switch (Direction)
        {
            case Direction.ClockWise:
                Direction = Direction.AntiClockWise;
                break;

            case Direction.AntiClockWise:
                Direction = Direction.ClockWise;
                break;
        }
    }

    public void ResetPosition()
    {
        indicatorTransform.localPosition = initialPos;
        indicatorTransform.localRotation = Quaternion.Euler(0, 0, 0);
    }

}

public enum Direction
{
    ClockWise = 1,
    AntiClockWise = -1
}
