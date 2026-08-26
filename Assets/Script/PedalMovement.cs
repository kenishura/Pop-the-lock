using UnityEngine;

public class PedalMovement : MonoBehaviour
{

    public Transform indicatorTransform;
    public Transform anchorTransform;
    public int rotationSpeed = 20;
    public Direction _direction = Direction.ClockWise;

    bool isRunning = false;

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
        else if (Input.GetMouseButtonDown(0)) {
            Debug.Log("Started Game");
            isRunning = true;
            return;
        }
    }

    void GameLoop()
    {
        indicatorTransform.RotateAround(anchorTransform.position, Vector3.forward, rotationSpeed * Time.deltaTime * -(int)_direction);

        if (Input.GetMouseButtonDown(0))
        {
            ChangeDirection();
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
