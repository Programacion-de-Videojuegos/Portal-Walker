using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CodigoSalud : MonoBehaviour
{
    public float Salud = 100;
    public float SaludMaxima = 100;


    [Header("Interfaz")]
    public Image BarraSalud;
    public Text TextoSalud;

  
    void Update()
    {
        ActualizarInterfaz();
    }
    public void RecibirDaño(float daño)
    {
        Salud -= daño;

        if (Salud <= 0) 
        {

            Cursor.lockState = CursorLockMode.None; // Desbloquea el cursor
            Cursor.visible = true; // Hace visible el cursor
            SceneManager.LoadScene("GameOver");
            
        }
    }

    void ActualizarInterfaz()
    {
        BarraSalud.fillAmount = Salud/SaludMaxima;
        TextoSalud.text = "+ " + Salud.ToString("f0");
    }
}
