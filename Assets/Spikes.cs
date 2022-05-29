using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    [SerializeField]
    private AudioClip audio;
    private AudioSource source;
    private DeathScript deathScript;
    void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
        source.clip = audio;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameManager.game.lose.enabled = true;
            StartCoroutine(WaitToDeath());
        }
    }
    private IEnumerator WaitToDeath()
    {
        source.Play();
        yield return new WaitForSeconds(2f);
        GameManager.game.Replay();
    }
}
