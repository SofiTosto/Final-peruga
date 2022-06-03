using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    public float movementspeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //transform.position += new Vector3(0, 0, 0.1f);
            transform.Translate(0, 0, movementspeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {

            transform.Translate(0, 0, -movementspeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.position += new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.position += new Vector3(-0.1f, 0, 0);
        }
    }

}
