using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class unoados : MonoBehaviour
{
    private void OnTriggerEnter(Collider ThirdPersonController)
    {
        SceneManager.LoadScene("Nivel2");
    }
}
