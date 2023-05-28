using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_movement : MonoBehaviour
{
    public float MaxEnginePower;
    public float MaxSteeringPower;
    private Rigidbody2D myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float power = Input.GetAxisRaw("Vertical");
        myRigidbody.AddForce(transform.up * MaxEnginePower * power, ForceMode2D.Force);

        float steering = Input.GetAxisRaw("Horizontal");
        myRigidbody.AddTorque(-steering * MaxSteeringPower, ForceMode2D.Force);
    }
}
