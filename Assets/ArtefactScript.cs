using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class ArtefactScript : MonoBehaviour
{
    public bool isEnter;
    public Counter counter;

    private void Start()
    {
        isEnter = false; 
    }
    private void Update()
    {
        UseItem();
    }
    public void UseItem()
    {
        if (isEnter)
        {
            counter.count += 1;
            counter.text.text = "Найдите все древние мечи : " + counter.count + " из " + counter.maxCountArtefacts;
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
