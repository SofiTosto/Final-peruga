using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    public GameObject Panelazul;
    public GameObject PanelCorre;
    public GameObject PanelGanar;
    public GameObject PanelPerdiste;
    public GameObject Moneda1;
    public GameObject Moneda2;
    public GameObject Moneda3;
    public GameObject Paredfinal;
    public Material rojo;
    public Material verde;
    public Material azul;
    public Material turquesa;
    public Material violeta;
    public Material rosa;
    float tiempo = 30;
    public bool contar = false;
    public MeshRenderer render;
    public GameObject[] monedas;
    public float movementspeed;

    private Material CubeComponent;
    // Start is called before the first frame update
    void Start()
    {
        monedas = new GameObject[3];
        monedas[0] = Moneda1;
        monedas[1] = Moneda2;
        monedas[2] = Moneda3;
        
    }
        // Update is called once per frame
        void Update()
    {
        if(tiempo <= 0)
        {
            PanelPerdiste.SetActive(true);
        }
        //Debug.Log(tiempo);
        if(tiempo > 0 && contar == true)
        {
            tiempo -= Time.deltaTime;
            //Debug.Log(colores[0]);
            
        }

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

        if (col.gameObject.name == "Ganaste")
        {
            PanelCorre.SetActive(true);
            contar = true;
            for (int i = 0; i < monedas.Length; i++)
            {
                monedas[i].SetActive(true);
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

        if (col.gameObject.name == "Moneda1")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "Moneda3")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "Moneda2")
        {
            Destroy(col.gameObject);
            Destroy(Paredfinal);
        }
        if (col.gameObject.name == "Ganar")
        {
            PanelGanar.SetActive(true);
        }




    }
     void OnCollisionExit(Collision col)
        {
        if (col.gameObject.name == "Pared")
        {
            Panelazul.SetActive(false);
            col.gameObject.SetActive(true);

        }
        if (col.gameObject.name == "Ganaste")
        {
            PanelCorre.SetActive(false);

        }



    }

}

    

