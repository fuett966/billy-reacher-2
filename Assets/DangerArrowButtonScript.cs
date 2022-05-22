using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerArrowButtonScript : MonoBehaviour
{
    public DangerArrowScript arrowScript;
    public AudioClip sound;
    private AudioSource newAudio;
    private bool isUsed;
    private void Awake()
    {
        newAudio = gameObject.GetComponent<AudioSource>();
        arrowScript = GetComponentInParent<DangerArrowScript>();
        isUsed = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(!isUsed && other.tag == "Player")
        {
            isUsed = true;
            newAudio.clip = sound;
            newAudio.Play();
            gameObject.transform.position = new Vector3(transform.position.x,transform.position.y - 0.08f,transform.position.z);
            arrowScript.EnableArrows();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            //gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 0.08f, transform.position.z);
            //arrowScript.DisableArrows();
        }
    }
}
