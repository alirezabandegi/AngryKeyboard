using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    private Rigidbody rb;

    private float HorizontalInput;
    private float moveSpeed = 7;
    private float jumpSpeed = 12;

    private bool isOnGround = true;

    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        PlayerOutOfScreen();

        GameOver();
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }

    private void PlayerMovement()
    {
        if (!gameOver)
        {
            HorizontalInput = Input.GetAxis("Horizontal");

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.right * HorizontalInput * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.right * HorizontalInput * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
            {
                rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
                isOnGround = false;
            }
        }
    }

    private void PlayerOutOfScreen()
    {
        if (gameObject.transform.position.x >= 9.5f)
        {
            gameObject.transform.position = new Vector3(9.5f, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else if (gameObject.transform.position.x <= -9.5f)
        {
            gameObject.transform.position = new Vector3(-9.5f, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else if (gameObject.transform.position.y >= 4)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 4f, gameObject.transform.position.z);
        }
    }

    public void GameOver()
    {
        if (gameObject.transform.position.y <= -4.5f)
        {
            gameOver = true;
        }
    }
}
