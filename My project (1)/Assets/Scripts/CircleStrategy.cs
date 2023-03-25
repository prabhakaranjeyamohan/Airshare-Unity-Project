using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleStrategy: MonoBehaviour
{
    public float radius;
    public float speed;

    void Update()
    {
        float angle = Time.time * speed;
        float x = Mathf.Cos(angle) * radius;
        float z = Mathf.Sin(angle) * radius;

        transform.position = new Vector3(x, transform.position.y, z);
    }

}
