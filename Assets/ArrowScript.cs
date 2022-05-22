using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public BoxCollider damageCollider;

    public void EnableDamageCollider()
    {
        damageCollider.enabled = true;
    }
    public void DisableDamageCollider()
    {
        damageCollider.enabled = false;
    }
}
