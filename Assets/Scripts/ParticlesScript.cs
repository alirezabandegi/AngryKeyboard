using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesScript : MonoBehaviour
{
    public GameObject whichParticle;
    public GameObject where;

    public float timeToDestroy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeToDestroy += Time.deltaTime;
        if (timeToDestroy > 2 && gameObject.CompareTag("Particle"))
        {
            Destroy(gameObject);
        }
        if (timeToDestroy > 3 && gameObject.CompareTag("Start Place"))
        {
            Instantiate(whichParticle, new Vector3(where.transform.position.x, where.transform.position.y, where.transform.position.z), whichParticle.transform.rotation);
            Destroy(gameObject);
        }
    }
}
