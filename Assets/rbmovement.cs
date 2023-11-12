using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class rbmovement : MonoBehaviour
    //Inherits from the class monobehaviour
{
    public Rigidbody rb;
    public Vector3 movement;

    //Attributes related to heading
    float degreesPerSecond = 5;
    public float current_heading;
    public float target_heading;

    //attributes related to speed
    public float speed = 0;
    public float target_speed = 0;

    //attributes related to altitude
    public float altitude;
    public float target_altitude;
    float feet_per_second = 41;


    // Start is called before the first frame update
    void Start()
    {
        //gets the rigid body component
        rb = this.GetComponent<Rigidbody>();

        target_altitude = altitude;
        transform.position = transform.position + new Vector3(0,0,altitude) * 0.001f;
    }

    // Update is called once per frame
    void Update()
    {
        //this vector can be changed when user inputs are added
        movement = new Vector3(0,1,0) ;

    }

    //Fixed update is called once every 50 seconds
    void FixedUpdate()
    {
        moveAircraft(movement);

        //Increases the speed by 0.01 50 times a second if the target speed is greater than the current speed
        if (speed < target_speed)
        {
            speed = (float)(speed + 0.02);
        }

        //Decreases the speed by 0.01 50 times a second if the target speed is less than the current speed
        if (speed > target_speed)
        {
            speed = (float)(speed - 0.02);
        }

        //rotation system
        if (target_heading > current_heading)
        {
            if (target_heading < current_heading + 180)
            {
                transform.Rotate(new Vector3(0, 0, -(degreesPerSecond)) * Time.deltaTime);
                current_heading = current_heading + (degreesPerSecond * Time.deltaTime);
            }
            if (target_heading > current_heading + 180)
            {
                transform.Rotate(new Vector3(0, 0, (degreesPerSecond)) * Time.deltaTime);
                current_heading = current_heading - (degreesPerSecond * Time.deltaTime);
            }

        }

        
        if (target_heading < current_heading)
        {
            if (target_heading < current_heading - 180)
            {
                transform.Rotate(new Vector3(0, 0, -(degreesPerSecond)) * Time.deltaTime);
                current_heading = current_heading + (degreesPerSecond * Time.deltaTime);
            }
            if (target_heading > current_heading - 180)
            {
                transform.Rotate(new Vector3(0, 0, (degreesPerSecond)) * Time.deltaTime);
                current_heading = current_heading - (degreesPerSecond * Time.deltaTime);
            }

        }

        if (current_heading < 0)
        {
            current_heading = 360f;
        }
        if (current_heading > 360)
        {
            current_heading = 0f;
        }

        //altitude

        if (target_altitude > altitude)
        {
            altitude = altitude + feet_per_second * Time.deltaTime;
            rb.velocity = rb.velocity + new Vector3(0, 0, 2.05f) * Time.deltaTime;
        }
        if (target_altitude < altitude)
        {
            altitude = altitude - feet_per_second * Time.deltaTime;
            rb.velocity = rb.velocity + new Vector3(0, 0, -2.05f) * Time.deltaTime;
        }



    }
    void moveAircraft(Vector3 direction)
    {
        //Moves the aircraft in the direction of the Vector3 "Movement" at the speed set at the start.
        rb.velocity = rb.rotation*(direction*speed);

    }
}

