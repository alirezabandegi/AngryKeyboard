using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomTextScript : MonoBehaviour
{

    public TextMeshProUGUI textMesh;
    public string[] keyboardButtonNames;

    // Start is called before the first frame update
    void Start()
    {
        int randomKeyboardButton = Random.Range(0, 32);
        textMesh.text = keyboardButtonNames[randomKeyboardButton];
    }

    // Update is called once per frame
    void Update()
    {

    }
}
