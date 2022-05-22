using UnityEngine;

public class DeathScript : MonoBehaviour
{
    [HideInInspector]
    public Counter counter;

    void Start()
    {
        counter = FindObjectOfType<Counter>();
    }
}
