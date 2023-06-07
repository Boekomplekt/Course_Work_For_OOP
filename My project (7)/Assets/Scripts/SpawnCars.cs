using System.Collections;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    public GameObject[] cars;
    private float[] positions = { -1.73f, -0.54f, 0.63f, 1.79f };
    void Start()
    {
        StartCoroutine(spawn());
    }
    IEnumerator spawn()
    {
        while (true)
        {
            Instantiate(cars[Random.Range(0,cars.Length)],
                new Vector3(positions[Random.Range(0,4)] ,7f,0),
                Quaternion.Euler(new Vector3(90,180,0))
                );
            yield return new WaitForSeconds(1f);
        }
    }

}
