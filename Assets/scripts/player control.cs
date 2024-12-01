using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public float SpeedX;
    public float SpeedY;
    private float Horizontal;
    private float Vertical;
    private Rigidbody2D _componentRigiBody2D;
    public GameObject prefabBullet;
    public AudioSource sfxAudio;
    public int Life;
    // Start is called before the first frame update
    void Awake()
    {
        _componentRigiBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(prefabBullet, transform.position, transform.rotation);
            sfxAudio.Play();
        }
    }
    void FixedUpdate()
    {
        _componentRigiBody2D.velocity = new Vector2(Horizontal*SpeedX,Vertical*SpeedY);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemigo")
        {
            Life = Life - 1;
            if (Life == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
