using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    public GameObject Panelazul;
    public Material rojo;
    public Material verde;
    public Material azul;
    public Material turquesa;
    public Material violeta;
    public Material rosa;

    public MeshRenderer render;

    public float movementspeed;

    private Material CubeComponent;
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
            transform.Translate(Vector3.forward * movementspeed, Space.World);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {

            transform.Translate(Vector3.forward * -movementspeed, Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.Translate(Vector3.right * movementspeed, Space.World);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.Translate(Vector3.right * -movementspeed, Space.World);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Pared")
        {
           
            if (gameObject.name ==  "azulcubo")
            {
                //   render.enabled = false;
                col.gameObject.SetActive(false);
            }
            else
            {   
                Panelazul.SetActive(true);
                

            }
        }

        if (col.gameObject.name == "pared2")
        {

            if (gameObject.name == "verdecubo")
            {
               
                col.gameObject.SetActive(false);
            }
            
            
        }
        if (col.gameObject.name == "pared3")
        {

            if (gameObject.name == "violetacubo")
            {
                
                col.gameObject.SetActive(false);
            }


        }
        if (col.gameObject.name == "pared4")
        {

            if (gameObject.name == "rojocubo")
            {
                
                col.gameObject.SetActive(false);
            }


        }
        if (col.gameObject.name == "pared5")
        {

            if (gameObject.name == "turquesacubo")
            {

                col.gameObject.SetActive(false);
            }


        }
        if (col.gameObject.name == "pared1")
        {

            if (gameObject.name == "rosacubo")
            {

                col.gameObject.SetActive(false);
            }


        }

        if (col.gameObject.name == "Rojo")
        {
            gameObject.GetComponent<MeshRenderer>().material = rojo;
            gameObject.name = "rojocubo";
        }
        if (col.gameObject.name == "Rosa")
        {
            gameObject.GetComponent<MeshRenderer>().material = rosa;
            gameObject.name = "rosacubo";
        }

        if (col.gameObject.name == "Turquesa")
        {
            gameObject.GetComponent<MeshRenderer>().material = turquesa;
            gameObject.name = "turquesacubo";
        }

        if (col.gameObject.name == "Azul")
        {
            gameObject.GetComponent<MeshRenderer>().material = azul;
            gameObject.name = "azulcubo";
        }

        if (col.gameObject.name == "Violeta")
        {
            gameObject.GetComponent<MeshRenderer>().material = violeta;
            gameObject.name = "violetacubo";
        }

        if (col.gameObject.name == "Verde")
        {
            gameObject.GetComponent<MeshRenderer>().material = verde;
            gameObject.name = "verdecubo";
        }






    }
     void OnCollisionExit(Collision col)
        {
        if (col.gameObject.name == "Pared")
        {
            Panelazul.SetActive(false);
            col.gameObject.SetActive(true);

        }
        


    }

}

    

