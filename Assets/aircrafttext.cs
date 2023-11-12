using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class aircrafttext2 : MonoBehaviour
{
    public TMP_Text aircraft;
    public GameObject aircraftobject;

    public rbmovement rbmovement;
    public Transform transform;
    float degreesPerSecond = 5;
    public Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        aircraft.text = aircraftobject.GetComponent<A1Name>().callsign;
    }
    void Update()
    {
        //this vector can be changed when user inputs are added

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (rbmovement.target_heading > Mathf.RoundToInt(rbmovement.current_heading))
        {
            if (rbmovement.target_heading < Mathf.RoundToInt(rbmovement.current_heading) + 180)
            {
                transform.Rotate(new Vector3(0, 0, (degreesPerSecond)) * Time.deltaTime);

            }
            if (rbmovement.target_heading > Mathf.RoundToInt(rbmovement.current_heading) + 180)
            {
                transform.Rotate(new Vector3(0, 0, -(degreesPerSecond)) * Time.deltaTime);

            }

        }


        if (rbmovement.target_heading < Mathf.RoundToInt(rbmovement.current_heading))
        {
            if (rbmovement.target_heading < Mathf.RoundToInt(rbmovement.current_heading) - 180)
            {
                transform.Rotate(new Vector3(0, 0, (degreesPerSecond)) * Time.deltaTime);
            }
            if (rbmovement.target_heading > Mathf.RoundToInt(rbmovement.current_heading) - 180)
            {
                transform.Rotate(new Vector3(0, 0, -(degreesPerSecond)) * Time.deltaTime);
            }

        }

    }
}
