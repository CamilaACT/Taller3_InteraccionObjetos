using System;
using System.Collections.Generic;
using UnityEngine;

public class Playermovemet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    int playerSpeed = 10;
    public LunaColor lunaColor;

    private Rigidbody rb;
    public bool estaSuelo = true;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public event EventHandler onKeyA;
    public event EventHandler onKeyB;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * playerSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            lunaColor.pintarLuna();
        }
        if (Input.GetKey(KeyCode.W))
        {
            lunaColor.despintarLuna();
        }
        if (Input.GetKey(KeyCode.A))
        {

            onKeyA?.Invoke(this, EventArgs.Empty);

        }
        if (Input.GetKey(KeyCode.S))
        {

            onKeyB?.Invoke(this, EventArgs.Empty);

        }


    }

    
}
