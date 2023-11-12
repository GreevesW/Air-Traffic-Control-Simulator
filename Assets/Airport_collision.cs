using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Airport_collision : MonoBehaviour
{
    public GameObject Aircraft;
    public GameObject aircraft_collision_detector;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        if(collision.gameObject.name == "Approach_Triangle")
        {
            Debug.Log("Collision with object");
            if(Aircraft.GetComponent<rbmovement>().altitude <= 2700)
            {
                Debug.Log("Correct altitude");
                if (Aircraft.GetComponent<rbmovement>().current_heading <= 285 && Aircraft.GetComponent<rbmovement>().current_heading >= 255)
                {
                    Debug.Log("Aircraft able to land");
                    StartCoroutine(Wait());
                }
            }

        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(4);
        Aircraft.SetActive(false);
        aircraft_collision_detector.gameObject.SetActive(false);
    }
}



