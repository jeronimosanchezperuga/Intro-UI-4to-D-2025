using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClaveManager : MonoBehaviour
{
    public TextMeshProUGUI txtResultado;
    public TMP_InputField inputClave;
    string claveCorrecta = "1234";
    string claveIngresada;
    string mensaje;

    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = "";
    }

    public void ChequearClave()
    {
        claveIngresada = inputClave.text;
        if (claveIngresada == claveCorrecta)
        {
            mensaje = "Clave correcta";
        }
        else
        {
            mensaje = "Clave Incorrecta";
        }

        txtResultado.text = mensaje;
    }  
}
