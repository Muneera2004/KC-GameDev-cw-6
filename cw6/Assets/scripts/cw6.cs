using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw6 : MonoBehaviour
{
    public float limits;
    public float movement;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //If the player pressed A 
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x != -limits)
        {
            transform.position = new Vector3(transform.position.x - movement, transform.position.y, transform.position.z);
        }
        //If the player pressed D
        else if (Input.GetKeyDown(KeyCode.D) && transform.position.x != limits)
        {
            //print("Player has preesed D");
            transform.position = new Vector3(transform.position.x + movement, transform.position.y, transform.position.z);
        }

    }
}