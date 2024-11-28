using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("Nivel 1");
    }

    public void EscenaReglas()
    {
        SceneManager.LoadScene("Reglas");
    }

    public void EscenaInicio()
    {
        SceneManager.LoadScene("Menu");
    }

    public void BotonRestart()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Salir()
    {
        Application.Quit();
    }
}
