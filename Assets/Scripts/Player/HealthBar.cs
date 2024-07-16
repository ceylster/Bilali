using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private Transform fillParent;

    private void Awake() 
    {
        fillParent = transform.GetChild(1);
    }

    public void SetHealthBar(int currentHealth, int maxHealth)
    {
        fillParent.transform.localScale = new Vector3((float)currentHealth / maxHealth, 1, 1);
    }
}
