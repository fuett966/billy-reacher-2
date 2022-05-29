using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour
{

    public GameObject Spot1ight;

    public bool onOff;
    void FixedUpdate()
    {
        if (onOff)
        {
            Spot1ight.SetActive(true);
        }
        else {
            Spot1ight.SetActive(false);
        }
        toggle();
    }

    public void toggle ()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            onOff = !onOff;
        }
    }
}
