using System;
using System.Collections.Generic;
using UnityEngine;

public class Estrellas : MonoBehaviour
{
    public List<GameObject> estrellas;

    private Playermovemet playermovemet;

    private void Start()
    {
        playermovemet = GameObject.FindGameObjectWithTag("Player").GetComponent<Playermovemet>();
        playermovemet.onKeyA += Pintar;
        playermovemet.onKeyB += DesPintar;
    }

    private void Pintar(object sender,EventArgs e)
    {
        
        foreach (GameObject item in estrellas)
        {
            item.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }

    private void DesPintar(object sender, EventArgs e)
    {
       
        foreach (GameObject item in estrellas)
        {
            item.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
