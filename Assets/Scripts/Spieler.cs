using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spieler : MonoBehaviour
{   
    public float Speed=3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.Translate(Vector2.up * Speed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("down"))
        {
            transform.Translate(Vector2.down * Speed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("right"))
        {
            transform.Translate(Vector2.right * Speed * Time.deltaTime, Space.World);
        }
        
        if (Input.GetKey("left"))
        {
            transform.Translate(Vector2.left * Speed * Time.deltaTime, Space.World);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
