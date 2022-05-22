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

        text.text = "Разгадай загадку, встав на платформу: Ты творец пшеницы и ячменя.Твои воды дают жизнь всему живому";
        redTEXT.text = "Нил";
        blueTEXT.text = "Асирис";
        greenTEXT.text = "Кратус";
        questionNumber = 0;
    }

    public void TriggerQueston()
    {
        switch (questionNumber)
        {
            case 0:
                if (redPlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    text.text = "Священное животное богини Баст ? ";
                    redTEXT.text = "Ястреб";
                    blueTEXT.text = "Крокодил";
                    greenTEXT.text = "Кошка";
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
                    text.text = "Высшее существо, озаряющее нас каждый день ";
                    redTEXT.text = "Аракс";
                    greenTEXT.text = "Гепосис";
                    blueTEXT.text = "Амон-Ра";
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
                    text.text = "Надену весной свой лучший наряд, зимою лишусь покрова;нагой простою - пусть другие дрожат, а к лету закутаюсь снова.";
                    redTEXT.text = "Земля";
                    blueTEXT.text = "Дерево";
                    greenTEXT.text = "Заяц";
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
                    text.text = "Кто не дышит, но живёт;хоть не нужно - много пьет;и в жизни, и в смерти тело как лед";
                    redTEXT.text = "Рыба";
                    blueTEXT.text = "Червь";
                    greenTEXT.text = "Змея";
                    questionNumber = 4;
                }
                break;
            case 4:
                if (redPlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    text.text = "Ввысь идет, но не растет.На деревья сверху взирает, но корни свои скрывает";
                    redTEXT.text = "Солнце";
                    blueTEXT.text = "Человек";
                    greenTEXT.text = "Гора";
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
                    text.text = "Ночью на месте без лишних слов, к утру же очищен небесный покров.";
                    redTEXT.text = "Звёзды";
                    greenTEXT.text = "Луна";
                    blueTEXT.text = "Облака";
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
                    text.text = "Мертвых оживляет. Нас смешит,а порой - печалит.Рождается виг. Гибнет, когда ты - старик.";
                    redTEXT.text = "Смерть";
                    blueTEXT.text = "Память";
                    greenTEXT.text = "Памятник";
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
                    text.text = "Мала как песчинка, лечу как пушинка.Сначала услышишь, потом лишь заметишь.";
                    redTEXT.text = "Колибри";
                    blueTEXT.text = "Стрела";
                    greenTEXT.text = "Капля";
                    questionNumber = 8;
                }
                break;
            case 8:
                if (redPlatform.GetComponent<BossPlatformScript>().isHere)
                {
                    text.text = "Я жертву мягкой нитью обовью, а после обниму и отравлю.";
                    redTEXT.text = "Паук";
                    blueTEXT.text = "Искушение";
                    greenTEXT.text = "Медоед";
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
                    text.text = "Вдаль спешу, но не бегу. Всё шумлю, сама молчу. Бьюсь о край - слез не видать. Не проси , не двинусь вспять.";
                    redTEXT.text = "Птица";
                    blueTEXT.text = "Облако";
                    greenTEXT.text = "Река";
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
                    text.text = "Поздравляю с победой...";
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

