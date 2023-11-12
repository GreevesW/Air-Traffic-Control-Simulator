using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.UI;

public class AltitudeDisplay : MonoBehaviour
{
    public GameObject aircraft;
    public Text ValueText;
    public float Output;
    public float Output2;
    // Start is called before the first frame update
    void Start()
    {
        Output = aircraft.GetComponent<rbmovement>().altitude;
        Output2 = Mathf.RoundToInt(Output);
        //Output3 = decimal.Round(Output2);
        ValueText.text = Output2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Output = aircraft.GetComponent<rbmovement>().altitude;
        //Outtput2 = (int)Output;
        Output2 = Mathf.RoundToInt(Output);
        ValueText.text = "Altitude:" + Output2.ToString();
    }
}
