using UnityEngine;

public class PedalMovement : MonoBehaviour
{

    public Transform indicatorTransform;
    public Transform anchorTransform;
    public int rotationSpeed = 20;
    public Direction _direction = Direction.ClockWise;

    public bool isRunning = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            GameLoop();
        }
        else if (_didTap) {
            Debug.Log("Started Game");
            isRunning = true;
            return;
        }
    }

    void GameLoop()
    {
        indicatorTransform.RotateAround(anchorTransform.position, Vector3.forward, rotationSpeed * Time.deltaTime * -(int)_direction);

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
        switch (_direction)
        {
            case Direction.ClockWise:
                _direction = Direction.AntiClockWise;
                break;

            case Direction.AntiClockWise:
                _direction = Direction.ClockWise;
                break;
        }
    }

    public enum Direction
    {
         ClockWise = 1,
         AntiClockWise = -1
    }

}
