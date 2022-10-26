using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SpawnManagerSceipts : MonoBehaviour
{
    public GameObject keyboardButtonPrefab;
    public GameObject player;

    private PlayerControllerScript playerController;


    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerControllerScript>();
        spawnKeyboardButton();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnKeyboardButton()
    {
        if (playerController.gameOver == false)
        {
            Vector3 keyboardButtonPrefabPos = new Vector3(12, Random.Range(-2.5f, 1.5f), 3);
            Instantiate(keyboardButtonPrefab, keyboardButtonPrefabPos, keyboardButtonPrefab.transform.rotation);
        }

        Invoke("spawnKeyboardButton", Random.Range(1, 3));
    }
}
