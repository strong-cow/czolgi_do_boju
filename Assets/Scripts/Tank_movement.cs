using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Tank_movement : MonoBehaviour
{
    public float MaxEnginePower;
    public float MaxSteeringPower;
    private Rigidbody2D myRigidbody;
    public GameObject target;
    
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target.CompareTag("Player1") == true) { Player1Control(); }
        if (target.CompareTag("Player2") == true) { Player2Control(); }

    }
    
    void Player1Control()
    {

        float power = 0;
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            power = 1;
        }
        else if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            power = -1;
        }

        myRigidbody.AddForce(transform.up * MaxEnginePower * power, ForceMode2D.Force);

        float steering = 0;
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            steering = 1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            steering = -1;
        }
        myRigidbody.AddTorque(-steering * MaxSteeringPower, ForceMode2D.Force);
    }
        
    void Player2Control()
    {

        float power = 0;
        if (Input.GetKey(KeyCode.W) == true)
        {
            power = 1;
        }
        else if (Input.GetKey(KeyCode.S) == true)
        {
            power = -1;
        }

        myRigidbody.AddForce(transform.up * MaxEnginePower * power, ForceMode2D.Force);

        float steering = 0;
        if (Input.GetKey(KeyCode.D) == true)
        {
            steering = 1;
        }
        else if (Input.GetKey(KeyCode.A) == true)
        {
            steering = -1;
        }
        myRigidbody.AddTorque(-steering * MaxSteeringPower, ForceMode2D.Force);
    }
}
