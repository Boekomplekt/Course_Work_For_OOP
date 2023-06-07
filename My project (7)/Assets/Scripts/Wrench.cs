
using System.Collections;
using System.Threading;
using UnityEngine;

public class Wrench : MonoBehaviour
{
    public GameObject wrench;
    private float[] positions = { -1.73f, -0.54f, 0.63f, 1.79f };

    void Start()
    {
        StartCoroutine(spawn());
    }
    IEnumerator spawn()
    {
        while (true)
        {
            Instantiate(wrench,
                new Vector3(positions[Random.Range(0, 4)], 8f, -0.5f),
                Quaternion.Euler(new Vector3(90, 180, 0))
                );
            yield return new WaitForSeconds(20f);
        }
    }

}
