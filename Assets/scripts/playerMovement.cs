using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float velocity;
    private Vector2 movement;
    private Rigidbody2D _rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float directionInput = Input.GetAxis("Horizontal");
        movement = new Vector2(directionInput, 0f);
        Debug.Log(directionInput);



    }
    void FixedUpdate()
    {
        float horizontalVelocity = movement.x * velocity;
        _rigidBody.velocity = new Vector2(horizontalVelocity, _rigidBody.velocity.y);

    }
}
