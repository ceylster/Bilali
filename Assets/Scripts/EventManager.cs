using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    public static EventManager instance;
    private void Awake()
    {
        instance = this;
    }

    public Action<PowerupType> OnPowerupTaken;
    public void ONOnPowerupTaken(PowerupType type)
    {
        OnPowerupTaken?.Invoke(type);
    }
}
