using UnityEngine;

public class ArtefactScript : MonoBehaviour
{
    public Counter counter;
    public AudioClip sound;
    private AudioSource newAudio;
    [SerializeField]
    private GameObject sword;

    private void Start()
    {
        newAudio = gameObject.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            newAudio.clip = sound;
            newAudio.Play();
            counter.count += 1;
            if (!counter.isBoss)
            {
                counter.text.text = "Соберите все проклятые клинки мести : " + counter.count + " из " + counter.maxCountArtefacts;
            }
            Destroy(sword);
            Destroy(gameObject.GetComponent<BoxCollider>());
        }
    }
}
