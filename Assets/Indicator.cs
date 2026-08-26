using UnityEngine;

public class Indicator : MonoBehaviour
{
    GameObject target;

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
}
