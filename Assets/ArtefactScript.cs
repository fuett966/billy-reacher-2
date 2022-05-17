using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class ArtefactScript : MonoBehaviour
{
    public bool isEnter;
    public Counter counter;
    [HideInInspector]public AudioManager audioManager;
    public AudioClip audioClip;

    private void Start()
    {
        isEnter = false;
        audioManager = GetComponent<AudioManager>();
    }
    private void Update()
    {
        UseItem();
    }
    public void UseItem()
    {
        if (isEnter)
        {
            //audioManager.PlayAudio(audioClip);
            counter.count += 1;
            counter.text.text = "Соберите все проклятые клинки мести : " + counter.count + " из " + counter.maxCountArtefacts;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isEnter = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            isEnter = false;
        }
    }
}
