using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Togglescript : MonoBehaviour {

    Toggle toggle;

    private void Start()
    {
        toggle = GetComponent<Toggle>();
    }

    public GameObject Slider;


    private void FixedUpdate()
    {
        if (toggle.isOn)
        {
            Slider.SetActive(false);
        }
        else
        {
            Slider.SetActive(true);
        }
    }
}
