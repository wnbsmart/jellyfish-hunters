using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour {

    [SerializeField]
    private float speed = 3f;

    private Rigidbody2D rigidBody2D;

    private void Awake()
    {
        RandomRotation();
        //transform.rotation.z = Random.rotation.z;
        //rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate ()
    {
        
        //rigidBody2D.velocity = Random.onUnitSphere * speed;
       transform.Translate(Vector3.right * Time.deltaTime * speed, Space.Self);
    }

    private void RandomRotation ()
    {
        Vector3 euler = transform.eulerAngles;
        euler.z = Random.Range(0.0f, 360.0f);
        transform.eulerAngles = euler;
    }
}
