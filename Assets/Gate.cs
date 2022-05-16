using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gate : MonoBehaviour
{
    public bool allIsCollected;
    public Counter counter;
    public int nextSceneNumber;
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
            allIsCollected = true;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && allIsCollected)
        {
            SceneManager.LoadScene(nextSceneNumber);
        }
    }
}
