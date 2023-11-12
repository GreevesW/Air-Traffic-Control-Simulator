using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Aircraft_Proximity : MonoBehaviour
{
    public GameObject aircraft1;
    public GameObject aircraft2;
    public GameObject aircraft3;

    public SpriteRenderer spriteRenderer;

    public TMP_Text warning_diplay;

    public GameObject panel;


    // Start is called before the first frame update
    void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.spriteRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Proximity_Collider_1")
        {
            if ((GetComponentInParent<rbmovement>().altitude) - (aircraft1.GetComponent<rbmovement>().altitude) < 1000)
            {
                if ((GetComponentInParent<rbmovement>().altitude) - (aircraft1.GetComponent<rbmovement>().altitude) > -1000)
                {
                    Debug.Log(GetComponentInParent<Spawnscript>().callsign + " is too close to " + aircraft1.GetComponent<Spawnscript>().callsign);

                    panel.SetActive(true);
                    warning_diplay.text = GetComponentInParent<Spawnscript>().callsign + " is too close to " + aircraft1.GetComponent<Spawnscript>().callsign;

                    this.spriteRenderer = GetComponent<SpriteRenderer>();
                    this.spriteRenderer.enabled = true;
                }
            }


        }
        if (collision.gameObject.name == "Proximity_Collider_2")
        {
            if ((GetComponentInParent<rbmovement>().altitude) - (aircraft2.GetComponent<rbmovement>().altitude) < 1000)
            {
                if ((GetComponentInParent<rbmovement>().altitude) - (aircraft2.GetComponent<rbmovement>().altitude) > -1000)
                {
                    Debug.Log(GetComponentInParent<Spawnscript>().callsign + " is too close to " + aircraft2.GetComponent<Spawnscript>().callsign);

                    panel.SetActive(true);
                    warning_diplay.text = GetComponentInParent<Spawnscript>().callsign + " is too close to " + aircraft2.GetComponent<Spawnscript>().callsign;

                    this.spriteRenderer = GetComponent<SpriteRenderer>();
                    this.spriteRenderer.enabled = true;
                }
            }
        }
        if (collision.gameObject.name == "Proximity_Collider_3")
        {
            if ((GetComponentInParent<rbmovement>().altitude) - (aircraft3.GetComponent<rbmovement>().altitude) < 1000)
            {
                if ((GetComponentInParent<rbmovement>().altitude) - (aircraft3.GetComponent<rbmovement>().altitude) > -1000)
                {
                    Debug.Log(GetComponentInParent<Spawnscript>().callsign + " is too close to " + aircraft3.GetComponent<Spawnscript>().callsign);

                    panel.SetActive(true);
                    warning_diplay.text = GetComponentInParent<Spawnscript>().callsign + " is too close to " + aircraft3.GetComponent<Spawnscript>().callsign;

                    this.spriteRenderer = GetComponent<SpriteRenderer>();
                    this.spriteRenderer.enabled = true;
                }
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        this.spriteRenderer.enabled = false;
        warning_diplay.text = " ";
    }
}
