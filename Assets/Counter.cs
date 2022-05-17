using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public ArtefactScript[] artefactArray;
    [HideInInspector] public float count;
    public Text text;
    [HideInInspector]public int maxCountArtefacts;
    public float timeToChangeTextToFindExit;
    private float timer;
    private bool isTimer;
    private bool isUpdateText;
    public int thisSceneNumber;

    void Start()
    {
        count = 0;
        maxCountArtefacts = artefactArray.Length;
        text.text = "Соберите все проклятые клинки мести : 0 из " + maxCountArtefacts;
        timer = timeToChangeTextToFindExit;
        isUpdateText = true;
        isTimer = false;
    }

    private void Update()
    {
        if (text.text == "Соберите все проклятые клинки мести : " + maxCountArtefacts + " из " + maxCountArtefacts && !isTimer)
        {
            text.color = new Color(0, 255, 0);
            isTimer = true;
        }
        else if(isTimer)
        {
            timer =- Time.deltaTime;
            if (timer <= 0)
            {
                text.text = "Найдите выход";
                text.color = new Color(255, 255, 255);
                isUpdateText = false;
            }
        }
        else if(isUpdateText)
        {
            text.text = "Соберите все проклятые клинки мести : " + count + " из " + maxCountArtefacts;
        }

    }


}
