using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hello2 : MonoBehaviour
{

    [SerializeField] private string message = "Hello there";
    [SerializeField] private float rotationSpeed = 40f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message);
        Console.Write("Aqui, imprime"); 
    }

    // Update is called once per frame
    void Update()
    {
        //float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, 0f, rotationSpeed); 
    }
}
