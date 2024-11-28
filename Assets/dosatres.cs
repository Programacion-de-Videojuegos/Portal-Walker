using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dosatres : MonoBehaviour
{
    private void OnTriggerEnter(Collider ThirdPersonController)
    {
        SceneManager.LoadScene("Nivel3");
    }
}
