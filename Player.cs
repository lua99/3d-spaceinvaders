using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody rb;
    private float direction;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); //getting refernce for rigidbody
    }

    // Update is called once per frame
    void Update()
    {

       direction= Input.GetAxisRaw("Horizontal"); // getting info about our horizontal input
        rb.velocity = new Vector3(direction * moveSpeed, 0, 0); //moving our player

    }
}
