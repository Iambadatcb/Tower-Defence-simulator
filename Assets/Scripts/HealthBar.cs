using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public void DisplayHealth(int maxHealth, int health, int damage)
    {
        transform.localScale = new Vector3((float)health / maxHealth, 1, 1);
    }
}
