using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealPowerUp : Powerup
{
    public override void Deactivate()
    {
        base.Deactivate();
        Invoke(nameof(Activate),2f);
    }

    public override void Activate()
    {
        base.Activate();
        Debug.Log("Heal Activated");
    }
}
