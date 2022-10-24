using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovmentScript : MonoBehaviour
{
    private Rigidbody rb;
    private float HorizontalInput;
    private float moveSpeed = 7;
    private float jumpSpeed = 12;
    private bool isOnGround = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * HorizontalInput * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * HorizontalInput * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}