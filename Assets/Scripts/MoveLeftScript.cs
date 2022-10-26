using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftScript : MonoBehaviour
{
    public float speed;

    private PlayerControllerScript playerController;

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerControllerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
