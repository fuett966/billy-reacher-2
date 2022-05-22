using UnityEngine;

public class DangerArrowScript : MonoBehaviour
{
    public GameObject arrows;
    public BoxCollider damageCollider;

    public void EnableArrows()
    {
        arrows.active = true;
    }

    public void DisableArrows()
    {
        arrows.active = false;
    }
}
