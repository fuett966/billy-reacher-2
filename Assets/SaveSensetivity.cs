using UnityEngine;
using UnityEngine.UI;

public class SaveSensetivity : MonoBehaviour
{
    [SerializeField]
    private Slider sliderCam;
    [SerializeField]
    private Slider sliderMove;
    private void Start()
    {
        LoadCam();
        LoadMove();
    }
    public void SaveCam()
    {
        PlayerPrefs.SetFloat("sensCam", sliderCam.value);
    }

    public void SaveMove()
    {
        PlayerPrefs.SetFloat("sens", sliderMove.value);
    }

    public void LoadCam()
    {
        sliderCam.value = PlayerPrefs.GetFloat("sensCam");
    }

    public void LoadMove()
    {
        sliderMove.value = PlayerPrefs.GetFloat("sensMove");
    }
}
