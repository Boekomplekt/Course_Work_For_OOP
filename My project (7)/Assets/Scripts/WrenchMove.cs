using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;


public class WrenchMove : MonoBehaviour
{
    public float speed = 1.5f;

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.y < -6)
        {

            Destroy(gameObject);
        }
    }
}
