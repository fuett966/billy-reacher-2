using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject Ui_JoyStick;
    public GameObject LevelsMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadLevel(int a)
    {
        SceneManager.LoadScene(a);
    }
    public void OpenMenuPanel()
    {
        Ui_JoyStick.active = false;
        MenuPanel.active = true;
    }
    public void CloseMenuPanel()
    {
        Ui_JoyStick.active = true; ;
        MenuPanel.active = false;
    }
    public void levelMenu()
    {
        LevelsMenu.active = !LevelsMenu.active;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
