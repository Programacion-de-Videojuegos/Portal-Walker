using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tresacuatro : MonoBehaviour
{
    private void OnTriggerEnter(Collider ThirdPersonController)
    {
        SceneManager.LoadScene("nivel4");
    }
}
