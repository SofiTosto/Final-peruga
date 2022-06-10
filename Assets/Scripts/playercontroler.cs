using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    public GameObject Panelsito;
    public Material rojo;
    public Material verde;
    public Material azul;

    public float movementspeed;

    private Material CubeComponent;
    // Start is called before the first frame update
    void Start()
    {
       CubeComponent = gameObject.GetComponent<Renderer>().material;
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
           CubeComponent = gameObject.GetComponent<Renderer>().material;
            if (CubeComponent == azul)
            {
            Destroy(col.gameObject);
            }
            else
            {
                Panelsito.SetActive(true);
                Debug.Log("no es azul.");
            }
        }
       
        if (col.gameObject.name == "Rojo")
        {
            gameObject.GetComponent<MeshRenderer>().material = rojo;
            
        }
        if (col.gameObject.name == "Azul")
        {
            gameObject.GetComponent<MeshRenderer>().material = azul;

        }
        if (col.gameObject.name == "Verde")
        {
            gameObject.GetComponent<MeshRenderer>().material = verde;

        }






    }
     void OnCollisionExit(Collision col)
        {
        if (col.gameObject.name == "Pared")
        {
            Panelsito.SetActive(false);
        }
      


    }

}

    

