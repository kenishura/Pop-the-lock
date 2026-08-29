using UnityEngine;

public class DotSpawner : MonoBehaviour
{
    public PedalMovement pedal;
    public GameObject dotPrefab;

    GameObject activeDot;
    public GameData gameData;

    private void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        if (activeDot != null) Destroy(activeDot);
        if(gameData.dotsRemaining > 0)
        {
            var ang = Random.Range(20, 120);
            activeDot = Instantiate(dotPrefab, pedal.indicatorTransform.position, Quaternion.identity, transform);
            activeDot.transform.RotateAround(transform.position, Vector3.forward, -ang * (int)pedal.Direction);
        }

    }
}
