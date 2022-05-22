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

        text.text = "�������� �������, ����� �� ���������: �� ������ ������� � ������.���� ���� ���� ����� ����� ������";
        redTEXT.text = "���";
        blueTEXT.text = "������";
        greenTEXT.text = "������";
        questionNumber = 0;
    }

    public void TriggerQueston()
    {
        switch (questionNumber)
        {
            case 0:
                if (redPlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    text.text = "��������� �������� ������ ���� ? ";
                    redTEXT.text = "������";
                    blueTEXT.text = "��������";
                    greenTEXT.text = "�����";
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
                    text.text = "������ ��������, ��������� ��� ������ ���� ";
                    redTEXT.text = "�����";
                    greenTEXT.text = "�������";
                    blueTEXT.text = "����-��";
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
                    text.text = "������ ������ ���� ������ �����, ����� ������ �������;����� ������� - ����� ������ ������, � � ���� ��������� �����.";
                    redTEXT.text = "�����";
                    blueTEXT.text = "������";
                    greenTEXT.text = "����";
                    questionNumber = 3;
                }
                break;
            case 3:
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
                    text.text = "��� �� �����, �� ����;���� �� ����� - ����� ����;� � �����, � � ������ ���� ��� ���";
                    redTEXT.text = "����";
                    blueTEXT.text = "�����";
                    greenTEXT.text = "����";
                    questionNumber = 4;
                }
                break;
            case 4:
                if (redPlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    text.text = "����� ����, �� �� ������.�� ������� ������ �������, �� ����� ���� ��������";
                    redTEXT.text = "������";
                    blueTEXT.text = "�������";
                    greenTEXT.text = "����";
                    questionNumber = 5;
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
            case 5:
                if (redPlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    GameManager.game.lose.enabled = true;
                    StartCoroutine(WaitToDeath());
                }
                else if (greenPlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    text.text = "����� �� ����� ��� ������ ����, � ���� �� ������ �������� ������.";
                    redTEXT.text = "�����";
                    greenTEXT.text = "����";
                    blueTEXT.text = "������";
                    questionNumber = 6;
                }
                else if (bluePlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    GameManager.game.lose.enabled = true;
                    StartCoroutine(WaitToDeath());
                }
                break;
            case 6:
                if (redPlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    text.text = "������� ��������. ��� ������,� ����� - �������.��������� ���. ������, ����� �� - ������.";
                    redTEXT.text = "������";
                    blueTEXT.text = "������";
                    greenTEXT.text = "��������";
                    questionNumber = 7;
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
            case 7:
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
                    text.text = "���� ��� ��������, ���� ��� �������.������� ��������, ����� ���� ��������.";
                    redTEXT.text = "�������";
                    blueTEXT.text = "������";
                    greenTEXT.text = "�����";
                    questionNumber = 8;
                }
                break;
            case 8:
                if (redPlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    text.text = "� ������ ������ ����� ������, � ����� ������ � �������.";
                    redTEXT.text = "����";
                    blueTEXT.text = "���������";
                    greenTEXT.text = "������";
                    questionNumber = 9;
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
            case 9:
                if (redPlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    text.text = "����� �����, �� �� ����. �� �����, ���� �����. ����� � ���� - ���� �� ������. �� ����� , �� ������� ������.";
                    redTEXT.text = "�����";
                    blueTEXT.text = "������";
                    greenTEXT.text = "����";
                    questionNumber = 10;
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
            case 10:
                if (redPlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    GameManager.game.lose.enabled = true;
                    StartCoroutine(WaitToDeath());
                }
                else if (greenPlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    text.text = "���������� � �������...";
                    redTEXT.text = "";
                    greenTEXT.text = "";
                    blueTEXT.text = "";
                    questionNumber = 11;

                }
                else if (bluePlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    GameManager.game.lose.enabled = true;
                    StartCoroutine(WaitToDeath());
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

