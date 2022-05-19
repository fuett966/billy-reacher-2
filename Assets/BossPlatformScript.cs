using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPlatformScript : MonoBehaviour
{
    public bool isHere;
    public BossFight bossFight;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isHere = true;
            bossFight.TriggerQueston();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isHere = false;
        }
    }
}
