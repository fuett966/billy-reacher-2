using UnityEngine;
using UnityEngine.SceneManagement;

public class Gate : MonoBehaviour
{
    public Counter counter;
    public int nextSceneNumber;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (counter.count == counter.maxCountArtefacts)
            {
                SceneManager.LoadScene(nextSceneNumber);
            }
        }
    }
}
