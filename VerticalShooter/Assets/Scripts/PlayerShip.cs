using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    [ContextMenu("Damage")]
    public void TakeGamage()
    {
        PlayerHealth.SetHealth(PlayerHealth.GetHealth() - 1);
    }
}
