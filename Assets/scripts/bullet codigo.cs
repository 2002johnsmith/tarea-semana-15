using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcodigo : MonoBehaviour
{
    public float velocidad;
    private Rigidbody2D _componentRigiBody2D;
    void Awake()
    {
        _componentRigiBody2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        _componentRigiBody2D.velocity = new Vector2(0, velocidad);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemigo"|| collision.gameObject.tag == "wall")
        {
            Destroy(this.gameObject);
        }
    }
}
