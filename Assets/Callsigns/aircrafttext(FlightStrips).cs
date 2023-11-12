using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class aircrafttext_FlightStrips : MonoBehaviour
{
    public TMP_Text aircraft;
    public GameObject aircraftobject;


    // Start is called before the first frame update
    void Start()
    {
        aircraft.text = aircraftobject.GetComponent<Spawnscript>().callsign;
    }
    void Update()
    {
        aircraft.text = aircraftobject.GetComponent<Spawnscript>().callsign;

    }
    // Update is called once per frame
}
