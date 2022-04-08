using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{

    string contraseniaCorrecta;
    string contraseniaUsuario;
    public Text ingresoUsuario;
    public Text textoMsj;
    public GameObject cartelitoMsj;
    // Start is called before the first frame update
    void Start()
    {
        contraseniaCorrecta = "12345";
        cartelitoMsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void validarContrasenia()
    {
        contraseniaUsuario = ingresoUsuario.text;
        if (contraseniaUsuario == contraseniaCorrecta)
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Contraseña Incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}
