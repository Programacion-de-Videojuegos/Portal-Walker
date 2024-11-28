using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody enemyRb;
    private GameObject player;
    private bool isTurning = false; // Indica si el enemigo est� girando

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player"); // Encuentra el objeto con el nombre "Player"
    }

    void FixedUpdate()
    {
        if (!isTurning)
        {
            MoveForward();
        }
    }

    private void MoveForward()
    {
        // Mueve al enemigo hacia adelante en la direcci�n actual
        enemyRb.MovePosition(transform.position + transform.forward * speed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Cuando el enemigo choca con un objeto, inicia la secuencia de giro hacia el jugador
        if (collision.collider.CompareTag("Obstaculo")) // Aseg�rate de que los obst�culos tengan esta etiqueta
        {
            StartCoroutine(TurnTowardsPlayer());
        }
    }

    private IEnumerator TurnTowardsPlayer()
    {
        if (player == null) yield break; // Si no hay jugador, no hacer nada

        isTurning = true; // Detenemos el movimiento durante el giro

        // Detenemos el movimiento actual
        enemyRb.velocity = Vector3.zero;

        // Calculamos la direcci�n hacia el jugador
        Vector3 directionToPlayer = (player.transform.position - transform.position).normalized;

        // Calculamos la rotaci�n final hacia el jugador
        Quaternion targetRotation = Quaternion.LookRotation(directionToPlayer);

        // Giramos hacia el jugador de forma gradual
        float elapsed = 0f;
        float turnDuration = 0.5f; // Duraci�n del giro (en segundos)

        Quaternion startRotation = transform.rotation;

        while (elapsed < turnDuration)
        {
            // Interpolamos entre la rotaci�n inicial y la final
            transform.rotation = Quaternion.Slerp(startRotation, targetRotation, elapsed / turnDuration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.rotation = targetRotation; // Aseguramos la rotaci�n final

        // Reanudar el movimiento
        isTurning = false;
    }
}