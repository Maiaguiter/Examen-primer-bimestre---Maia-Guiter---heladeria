using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{
    public string Gusto;
    public int Cantidad;


    // Start is called before the first frame update
    void Start()
    {
        float precio = Cantidad * 500 / 1000 / 2;
        float preciofrutilla = precio / 10;
        float preciodescuento = precio + preciofrutilla;
        string gusto = "CHO";
        string gusto2 = "FRU";
        string gusto3 = "DDL";

 
        if (gusto != "CHO"){
            Debug.Log("El codigo no es valido");
        }
        if (gusto != "FRU")
        {
            Debug.Log("El codigo no es valido");
        }
        if (gusto != "DDL")
        {
            Debug.Log("El codigo no es valido");
        }
        if (Cantidad > 3000 || Cantidad < 250)
        {
            Debug.Log("La cantidad no es valida");
        }
        else
        {
            if (gusto == "CHO")
            {
                Debug.Log("Su precio es de " + precio + " pesos");
            }
            if (gusto3 == "DDL")
            {
                Debug.Log("Su precio es de " + precio + " pesos");
            }
            if (gusto2 == "FRU")
            {
                Debug.Log("Su precio es de " + preciofrutilla + " pesos");
            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
