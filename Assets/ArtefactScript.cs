using UnityEngine;
using UnityEngine.SceneManagement;

public class ArtefactScript : MonoBehaviour
{
    public bool isEnter;
    public int scene;
    public Counter counter;

    public AudioClip sound;

    private AudioSource audio;

    private void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        isEnter = false;
    }
    private void Update()
    {
        UseItem();
    }
    public void UseItem()
    {
        if (isEnter)
        {
            audio.clip = sound;
            audio.Play();
            counter.count += 1;

            counter.text.text = "Соберите все проклятые клинки мести: " + counter.count + " из " + counter.maxCountArtefacts;
            if (counter.count == counter.maxCountArtefacts)
            {
                SceneManager.LoadScene(scene);
            }
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isEnter = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isEnter = false;
        }
    }
}
