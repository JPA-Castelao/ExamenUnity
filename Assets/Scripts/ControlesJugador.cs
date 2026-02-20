using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class ControlesJugador : MonoBehaviour
{

 private Rigidbody rb; 


 private float movementY;
 private float movementX;

 
 public float speed = 0;



 void Start()
    {
        rb = GetComponent<Rigidbody>();



    }
    private void FixedUpdate() 
    {
        
        Vector3 movement = new Vector3 (movementX, 0.0f, movementY);

        rb.AddForce(movement * speed); 
    }
    
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x; 
        movementY = movementVector.y; 
    }
 
    void OnTriggerEnter(Collider other) 
    {
        Debug.Log("Colision");
   
    }
private void OnCollisionEnter(Collision collision)
{
    
 if (collision.gameObject.CompareTag("Cubo"))
    {
        Debug.Log("Colision");
    }
  
    
}




}