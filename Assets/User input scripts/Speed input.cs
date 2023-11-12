using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedinput : MonoBehaviour
{
    //Defining the attributes for taking the user input
    public string input;
    public int output;

    [SerializeField] MindScript MindScript;

    //allows the attributes in the rbmovemnt script to be used
    [SerializeField] rbmovement rbmovement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //defines the method that will be called when the enter key is pressed
    public void ReadSpeedInput(string i)
    {
        input = i;

        //casts the string input as an int
        //rbmovement.target_speed = Int32.Parse(input);

        MindScript.CurrentPlayer.GetComponent<rbmovement>().target_speed = Int32.Parse(input);
    }
}
