using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    [SerializeField]
    private float speed = 1.5f;

    private Rigidbody2D rgbd2d;

    private float yAxis;
    private float xAxis;

    private float maxVelocity = 3;
    private float x;
    private float y;

    private float rotationSpeed = 3;
    

	// Use this for initialization
	private void Start () {
        rgbd2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        xAxis = Input.GetAxis("Horizontal");
        yAxis = Input.GetAxis("Vertical");

        ThrustForward(yAxis);

        Rotate(transform, xAxis * rotationSpeed);
    }

    private void FixedUpdate () {
        transform.Translate(Vector2.up * Time.deltaTime * speed, Space.Self);
    }

    private void ClampVelocity()
    {
        x = Mathf.Clamp(rgbd2d.velocity.x, -maxVelocity, maxVelocity);
        y = Mathf.Clamp(rgbd2d.velocity.y, -maxVelocity, maxVelocity);

        rgbd2d.velocity = new Vector2(x, y);
    }

    private void ThrustForward(float amount)
    {
        Vector2 force = transform.up * amount;

        rgbd2d.AddForce(force);
    }

    private void Rotate(Transform t, float amount)
    {
        t.Rotate(0, 0, amount);
    }
}
