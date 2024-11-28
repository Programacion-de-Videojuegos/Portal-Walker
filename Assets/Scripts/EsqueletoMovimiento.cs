using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsqueletoMovimiento : MonoBehaviour
{
    public float velocidad = 1f;
    private Vector3 direccionMovimiento;

    private Animator esqueletoAnimator;
    private float limiteXMin = -3f;
    private float limiteXMax = 9f;
    private float limiteZMin = -19f;
    private float limiteZMax = -5f;

    // Start is called before the first frame update
    void Start()
    {
        esqueletoAnimator = GetComponent<Animator>();
        direccionMovimiento = transform.forward;
        esqueletoAnimator.SetBool("walk", true);
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Esqueleto") || collision.gameObject.CompareTag("Obstaculo"))
        {
            CambiarDireccion();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direccionMovimiento * velocidad * Time.deltaTime);

        if (transform.position.x < limiteXMin || transform.position.x > limiteXMax ||
           transform.position.z < limiteZMin || transform.position.z > limiteZMax)
        {

            direccionMovimiento = -direccionMovimiento;
            transform.Rotate(0, 180, 0);
        }
    }

    void CambiarDireccion()
    {
        // Invertir la dirección y rotar 180 grados
        direccionMovimiento = -direccionMovimiento;
        transform.rotation = Quaternion.LookRotation(direccionMovimiento);
    }
}