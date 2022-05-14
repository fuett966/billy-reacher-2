using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gate : MonoBehaviour
{
    public bool allIsCollected;
    public Counter counter;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        allIsCollected = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(counter.count == counter.maxCountArtefacts)
        {
            //next level
        }
    }
}
