using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BossFight : MonoBehaviour
{

    [SerializeField]
    private AudioClip audio;
    private AudioSource source;

    public GameObject[] platforms;

    public GameObject redPlatform;
    public GameObject greenPlatform;
    public GameObject bluePlatform;


    public TextMesh redTEXT;
    public TextMesh greenTEXT;
    public TextMesh blueTEXT;

    public Text text;
    public GameObject textTimer;

    bool inRed;
    bool inBlue;
    bool inGreen;

    private int questionNumber;

    void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
        source.clip = audio;

        text.text = "�������� �� ������, ����� �� ���������: ������� ����� 2 + 2 ? ";
        redTEXT.text = "4";
        blueTEXT.text = "6";
        greenTEXT.text = "5";
        questionNumber = 0;
    }

    void Update()
    {

    }

    public void TriggerQueston()
    {
        switch (questionNumber)
        {
            case 0:
                if (redPlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    text.text = "�������� �� ������, ����� �� ���������: ������� ��� �� ����� ���������� ������ ? ";
                    redTEXT.text = "0";
                    blueTEXT.text = "�� �����";
                    greenTEXT.text = "����������";
                    questionNumber = 1;
                }
                else if (greenPlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    GameManager.game.lose.enabled = true;
                    StartCoroutine(WaitToDeath());
                }
                else if (bluePlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    GameManager.game.lose.enabled = true;
                    StartCoroutine(WaitToDeath());
                }
                break;
            case 1:
                if (redPlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    GameManager.game.lose.enabled = true;
                    StartCoroutine(WaitToDeath());
                }
                else if (greenPlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    text.text = "�������� �� ������, ����� �� ���������: ��-�� ���� ����� ������? ";
                    redTEXT.text = "����������";
                    greenTEXT.text = "����������";
                    blueTEXT.text = "�������";
                    questionNumber = 2;
                    
                }
                else if (bluePlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    GameManager.game.lose.enabled = true;
                    StartCoroutine(WaitToDeath());
                }
                break;
            case 2:
                if (redPlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    GameManager.game.lose.enabled = true;
                    StartCoroutine(WaitToDeath());
                }
                else if (greenPlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    GameManager.game.lose.enabled = true;
                    StartCoroutine(WaitToDeath());
                }
                else if (bluePlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    text.text = "���������� - ��� ������... ";
                    redTEXT.text = "";
                    blueTEXT.text = "";
                    greenTEXT.text = "";
                    questionNumber = 3;
                }
                break;
        }
    }
    private IEnumerator WaitToDeath()
    {
        source.Play();
        yield return new WaitForSeconds(2f);
        GameManager.game.Replay();
    }
}

