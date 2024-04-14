using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nubes : MonoBehaviour
{
    public List<GameObject> nubes;
    private jugadorEnvio jugador;
    public Material material;
    public Material materialinicial;

    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<jugadorEnvio>();
        jugador.onRecibo += PintarNubes;
    }

    private void PintarNubes(object sender, jugadorEnvio.OnTakeReciboArgs e)
    {
        if(e.cantidadChoques > 5)
        {
            foreach (GameObject item in nubes)
            {
                //item.GetComponent<Renderer>().material.color = Color.white;
                item.GetComponent<Renderer>().material = material;

            }
        }
        else
        {
            foreach (GameObject item in nubes)
            {
                //item.GetComponent<Renderer>().material.color = Color.white;
                item.GetComponent<Renderer>().material = materialinicial;

            }
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
