using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public MindScript mind;

    void OnMouseDown()
    {
        mind.ChangePlayer(this.gameObject);
        

    }

}
