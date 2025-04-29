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

    // Start is called before the first frame update
    void Start()
    {
        if(patenteAuto == "")
        {
            Debug.Log("El campo de patente es obligatorio. VTV no aprobada");
            return;
        }

        if(modeloAuto < 1900 && modeloAuto > 2025)
        {
            Debug.Log("VTV no aprobada");
            return;
        }

        if(kmAuto < 0)
        {
            Debug.Log("VTV no aprobada");
            return;
        }

        if(vencimientoAuto > 2025 && vencimientoAuto < modeloAuto)
        {
            Debug.Log("VTV no aprobada");
            return;
        }

        if(HCAuto < 5 && HCAuto > 100)
        {
            Debug.Log("VTV no aprobada");
            return;
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
