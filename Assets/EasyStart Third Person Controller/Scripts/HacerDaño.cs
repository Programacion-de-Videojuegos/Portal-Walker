using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HacerDaño : MonoBehaviour
{
    public float CantidadDaño;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && other.GetComponent<CodigoSalud>())
        {
            other.GetComponent<CodigoSalud>().RecibirDaño(CantidadDaño);
        }
    }
}
