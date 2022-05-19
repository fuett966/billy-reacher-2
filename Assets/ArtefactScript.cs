using UnityEngine;

public class ArtefactScript : MonoBehaviour
{
    public bool isEnter;
    public Counter counter;
    public AudioClip sound;
    public AudioSource newAudio;

    private void Start()
    {
        newAudio = gameObject.GetComponent<AudioSource>();
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
            newAudio.clip = sound;
            newAudio.Play();
            counter.count += 1;
            counter.text.text = "Соберите все проклятые клинки мести : " + counter.count + " из " + counter.maxCountArtefacts;
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
