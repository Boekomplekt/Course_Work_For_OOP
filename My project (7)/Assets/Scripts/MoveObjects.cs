using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    public float speed = 2.0f;

    
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.y < -6)
        {

            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<Collider>().enabled = false;
        }
    }
}