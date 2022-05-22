using UnityEngine;
using UnityEngine.UI;

public class SaveSensetivity : MonoBehaviour
{
    [SerializeField]
    private Slider slider;
    private void Start()
    {
        Load();
    }
    public void Save()
    {
        PlayerPrefs.SetFloat("sens", slider.value);
    }

    public void Load()
    {
        slider.value = PlayerPrefs.GetFloat("sens");
    }
}
