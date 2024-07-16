using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int maxHealth = 100;
    private int currentHealth;

    private float healInterval = 0.5f;
    private float nextHeal;

    private bool isHealing;

    private HealthBar playerHealthBar;
    void Start()
    {
        currentHealth = 50;
        playerHealthBar = GetComponentInChildren<HealthBar>();
        playerHealthBar.SetHealthBar(currentHealth,maxHealth);
        // EventManager.instance.OnPowerupTaken += HealUp;
    }

    // private void Update() 
    // {
    //     if(!isHealing) return;
    //     if(Time.time > nextHeal)
    //     {
    //         nextHeal = Time.time + healInterval;
    //         HealUp();
    //     }
    // }

    // public void OnEnterHealingPowerup()
    // {
    //     isHealing = true;
    // }

    // public void OnExitHealingPowerup()
    // {
    //     isHealing = false;
    // }

    public void HealUp()
    {
        if(currentHealth >= maxHealth) return;
        currentHealth = Mathf.Clamp(currentHealth + 25, 0, maxHealth);
        playerHealthBar.SetHealthBar(currentHealth,maxHealth);
    }
}
