using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificacionTecnicnaVehicular : MonoBehaviour
{
    public string patenteAuto;
    public int modeloAuto;
    public float kmAuto;
    public int vencimientoAuto;
    public int HCAuto;

    float kilometrajeAuto;

    // Start is called before the first frame update
    void Start()
    {
        if(patenteAuto == "")
        {
            Debug.Log("El campo de patente es obligatorio. VTV no aprobada");
            return;
        }

        if(modeloAuto < 1900 || modeloAuto > 2025)
        {
            Debug.Log("VTV no aprobada");
            return;
        }

        if(kmAuto < 0)
        {
            Debug.Log("VTV no aprobada");
            return;
        }

        if(vencimientoAuto > 2025 || vencimientoAuto < modeloAuto)
        {
            Debug.Log("VTV no aprobada");
            return;
        }

        if(HCAuto < 5 || HCAuto > 100)
        {
            Debug.Log("VTV no aprobada");
            return;
        }


    kilometrajeAuto = kmAuto/(2025 - modeloAuto);

    if(kilometrajeAuto < 10000)
    {
        Debug.Log("VTV otorgada por 2 años");
    }
    else if(kilometrajeAuto > 10000)
    {
        Debug.Log("VTV otorgada por 1 año");
    }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
