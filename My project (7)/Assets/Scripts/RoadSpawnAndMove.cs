using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.ComponentModel;

public class RoadSpawnAndMove : MonoBehaviour
{
    public float speed = 1.5f;
    public GameObject road;

    void FixedUpdate()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
        if (transform.position.y < -12f)
        {
            Instantiate(road, new Vector3(0f, 14.61f, 0f), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
