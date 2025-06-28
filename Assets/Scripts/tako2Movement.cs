using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tako2Movement : MonoBehaviour
{
    public GameObject ina;
    public float speed = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ina = GameObject.Find("ina_0");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = ina.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(transform.position, ina.transform.position, speed * Time.deltaTime);
    }
}
