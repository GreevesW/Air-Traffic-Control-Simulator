using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MindScript : MonoBehaviour
{
    public GameObject[] Players;
    [SerializeField]
    public GameObject CurrentPlayer;

    // Start is called before the first frame update
    void Start()
    {
        CurrentPlayer = Players[0];
    }
    public void ChangePlayer(GameObject player)
    {

        
        CurrentPlayer = player;
    }
}
