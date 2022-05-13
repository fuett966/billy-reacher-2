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
    // Start is called before the first frame update

    void Start()
    {
        count = 0;
        maxCountArtefacts = artefactArray.Length;
        text.text = "������� ��� ������� ���� : 0 �� " + maxCountArtefacts;
    }

    private void Update()
    {
        text.text = "������� ��� ������� ���� : " + count + " �� " + maxCountArtefacts;
    }


}
