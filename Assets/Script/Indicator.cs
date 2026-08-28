using UnityEngine;

public class Indicator : MonoBehaviour
{
    GameObject target;
    public PedalMovement pedalMovement;
    public GameEvent dotMissedEvent;
    public GameEvent dotScoredEvent;
    public GameData gameData;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Objective"))
        {
            target = collision.gameObject;
            Debug.Log("Target Found!!");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == target)
        {
            target = null;
            Debug.Log("Target Lost!!");
        }
    }

    private void Update()
    {
        if (pedalMovement._didTap && gameData.isRunning)
        {
            if (target != null) {
                Destroy(target);
                dotScoredEvent.Raise();
            }
            else
            {
                dotMissedEvent.Raise();
            }
        }
    }



}
