using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tako1Movement : MonoBehaviour
{
    [HideInInspector]
    public float speed = 1.0f;

    private Rigidbody2D myBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
