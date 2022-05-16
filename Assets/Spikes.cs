using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    private DeathScript deathScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //Destroy(other.gameObject);
            deathScript = other.gameObject.GetComponent<DeathScript>();
            deathScript.isDead = true;
        }
    }
}
