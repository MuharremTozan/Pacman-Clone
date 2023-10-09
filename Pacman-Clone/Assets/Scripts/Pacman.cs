using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pacman : MonoBehaviour
{
    private Rigidbody2D pacmanRigidbody;

    private void Awake()
    {
        pacmanRigidbody = GetComponent<Rigidbody2D>();
    }

    public void PacmanMovement()
    {
        Debug.Log("Move!");
        pacmanRigidbody.AddForce(Vector2.right * 5f , ForceMode2D.Impulse);
    }
}
