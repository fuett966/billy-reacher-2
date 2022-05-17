using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    [HideInInspector]public bool isDead;
    public Counter counter;
    
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        counter = FindObjectOfType<Counter>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isDead)
        {
            //audio death
            //Destroy(gameObject);
            RestartLevel();
        }
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(counter.thisSceneNumber);
    }
}
