using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.UI;

public class HeadingDisplay : MonoBehaviour
{
    public GameObject aircraft;
    public float Output;
    public float Output2;

    public Text ValueText;


    // Start is called before the first frame update
    void Start()
    {
        Output = aircraft.GetComponent<rbmovement>().current_heading;
        Output2 = Mathf.RoundToInt(Output);
        ValueText.text = Output2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Output = aircraft.GetComponent<rbmovement>().current_heading;

        Output2 = Mathf.RoundToInt(Output);
        ValueText.text = "Heading: " + Output2.ToString().PadLeft(3,'0');
    }
}
