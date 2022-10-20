using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour
{
    public float velocidad = 0;
    private Rigidbody2D _rb2d;
    private Transform _trans;
   
    // Start is called before the first frame update
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2 (direction, 0f);
        _rb2d.velocity = new Vector2 (movement.x * velocidad, _rb2d.velocity.y);
        
    }
}
