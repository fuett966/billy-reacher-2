using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public ArtefactScript[] artefactArray;
    public float count;
    public Text text;
    [HideInInspector] public int maxCountArtefacts;
    public float timeToChangeTextToFindExit;
    private float timer;
    private bool isTimer;
    private bool isUpdateText;
    public int thisSceneNumber;
    public bool isBoss;
    public bool isFinal;

    void Start()
    {
        count = 0;
        maxCountArtefacts = artefactArray.Length;
        if (!isBoss)
        {
            text.text = "�������� ��� ��������� ������ ����� : 0 �� " + maxCountArtefacts;
        }

        timer = timeToChangeTextToFindExit;
        isUpdateText = true;
        isTimer = false;

    }

    private void Update()
    {
        if (isFinal)
        {
            text.text = "������!";
        }
        else if (!isBoss)
        {
            if (text.text == "�������� ��� ��������� ������ ����� : " + maxCountArtefacts + " �� " + maxCountArtefacts && !isTimer)
            {
                text.color = new Color(0, 255, 0);
                isTimer = true;
            }
            else if (isTimer)
            {
                timer = -Time.deltaTime;
                if (timer <= 0)
                {
                    text.text = "������� �����";
                    text.color = new Color(255, 255, 255);
                    isUpdateText = false;
                }
            }
            else if (isUpdateText)
            {
                text.text = "�������� ��� ��������� ������ ����� : " + count + " �� " + maxCountArtefacts;
            }
        }
        
    }
}
