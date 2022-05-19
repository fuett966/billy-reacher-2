using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    [SerializeField]
    private AudioClip audio;
    private AudioSource source;
    private DeathScript deathScript;
    // Start is called before the first frame update
    void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
        source.clip = audio;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameManager.game.lose.enabled = true;
            StartCoroutine(WaitToDeath());
            //Destroy(other.gameObject);
            //deathScript = other.gameObject.GetComponent<DeathScript>();
            //deathScript.isDead = true;
        }
    }
    private IEnumerator WaitToDeath()
    {
        source.Play();
        yield return new WaitForSeconds(2f);
        GameManager.game.Replay();
    }
}
