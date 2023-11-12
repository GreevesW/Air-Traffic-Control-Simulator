using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnscript : MonoBehaviour
{
    public string callsign;
    List<string> companies = new List<string> { "BAW", "ANA", "JAL", "KLM", "EZY", "RYR", "AFR", "AAL", "ACL", "DLH", "FDX", "QTR", "UAL","KAL" };

    public GameObject aircraftobject;
    public Transform aircrafttag;

    public GameObject aircraft_collision_detector;

    // Start is called before the first frame update
    void Start()
    {

    }
    void OnEnable()
    {
        transform.position = new Vector3( 25000 , 25000, 10000 * 0.001f);
        aircraftobject.GetComponent<rbmovement>().current_heading = 0;
        aircraftobject.GetComponent<rbmovement>().target_heading = 0;
        aircraftobject.GetComponent<rbmovement>().speed = 0;
        aircraftobject.GetComponent<rbmovement>().target_speed = 0;

        float randomNumber = Random.Range(100, 999);
        Debug.Log(randomNumber);
        callsign = companies[Random.Range(0, companies.Count)] + randomNumber.ToString();
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(Random.Range(4, 20));

        int num = Random.Range(1, 5);
        Debug.Log(num);

        aircraft_collision_detector.gameObject.SetActive(true);

        float speed_val = Random.Range(160, 240);
        aircraftobject.GetComponent<rbmovement>().speed = speed_val;
        aircraftobject.GetComponent<rbmovement>().target_speed = speed_val;
        if (num == 1)
        {
            transform.position = new Vector3(Random.Range(-5000, 15000), -13000, 10000 * 0.001f);
        }
        if (num == 2)
        {
            aircrafttag.Rotate(0,0,90);
            transform.Rotate(0, 0, -90);
            aircraftobject.GetComponent<rbmovement>().current_heading = 90;
            aircraftobject.GetComponent<rbmovement>().target_heading = 90;
            
            transform.position = new Vector3(-22000, Random.Range(-5000, 5000), 10000 * 0.001f);
        }
        if (num == 3)
        {
            aircrafttag.Rotate(0, 0, 180);
            transform.Rotate(0, 0, -180);
            aircraftobject.GetComponent<rbmovement>().current_heading = 180;
            aircraftobject.GetComponent<rbmovement>().target_heading = 180;

            transform.position = new Vector3( Random.Range(-5000, 15000), 13000 , 10000 * 0.001f);
        }
        if (num == 4)
        {
            aircrafttag.Rotate(0, 0, 270);
            transform.Rotate(0, 0, -270);
            aircraftobject.GetComponent<rbmovement>().current_heading = 270;
            aircraftobject.GetComponent<rbmovement>().target_heading = 270;

            transform.position = new Vector3(22000, Random.Range(-5000, 5000), 10000 * 0.001f);
        }

    }
    void Update()
    {
        
    }

    // Update is called once per frame
}
