using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D _rb;
    private Vector2 movement;
    public bool isDecorationCollected;
    private Interactable currentInteractable;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.E) && currentInteractable != null)
        {
            currentInteractable.Interact();
        }
    }

    void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + movement * speed * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Interactable interactableObj = other.GetComponent<Interactable>();

        if (interactableObj != null)
        {
            currentInteractable = interactableObj;
            Debug.Log("Etkileþime girmek için E'ye bas.");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Interactable interactableObj = other.GetComponent<Interactable>();

        if (interactableObj != null && interactableObj == currentInteractable)
        {
            currentInteractable = null; 
        }
    }
}