using System;
using System.Collections.Generic;
using UnityEngine;

public class jugadorEnvio : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int actualRecibo;

    public event EventHandler<OnTakeReciboArgs> onRecibo;

    public class OnTakeReciboArgs: EventArgs
    {
        public int cantidadChoques;
    }
    
    public void TomarDato(  int recibe)
    {
        actualRecibo += recibe;
        onRecibo?.Invoke(this, new OnTakeReciboArgs { cantidadChoques = actualRecibo });
    }

    public void RestarDato(int recibo)
    {
        actualRecibo -= recibo;
        onRecibo?.Invoke(this, new OnTakeReciboArgs { cantidadChoques = actualRecibo });
    }
}
