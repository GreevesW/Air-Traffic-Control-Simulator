using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headinginput: MonoBehaviour
{
    //Defining the attributes for taking the user input
    [SerializeField] MindScript MindScript;
    public string input;
    public int output;

    //allows the attributes in the rbmovemnt script to be used
    //[SerializeField] rbmovement rbmovement;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    //defines the method that will be called when the enter key is pressed
    public void ReadHeadingInput(string i)
    {
        input = i;

        //casts the string input as an int
        MindScript.CurrentPlayer.GetComponent<rbmovement>().target_heading = Int32.Parse(input);

        //Test code
        output = Int32.Parse(input);
        Debug.Log(output);
    }
}
