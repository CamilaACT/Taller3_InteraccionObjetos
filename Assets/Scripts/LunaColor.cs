using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunaColor : MonoBehaviour
{
    public void pintarLuna()
    {
        GetComponent<Renderer>().material.color = Color.gray;
    }
    public void despintarLuna()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
