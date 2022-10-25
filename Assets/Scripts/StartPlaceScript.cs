using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlaceScript : MonoBehaviour
{
    public float timeToDestroy;
    public GameObject bigExplosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToDestroy += Time.deltaTime;
        if (timeToDestroy > 3 && gameObject.CompareTag("Start Place"))
        {
            Destroy(gameObject);
            Instantiate(bigExplosion, new Vector3(0, -2, 3), bigExplosion.transform.rotation);
        }
        if (timeToDestroy > 2 && gameObject.CompareTag("Particle"))
        {
            Destroy(gameObject);
        }
    }
}
