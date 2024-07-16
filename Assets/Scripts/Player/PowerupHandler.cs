using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupHandler : MonoBehaviour
{
    private PlayerController playerController;

    private void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.TryGetComponent<Powerup>(out Powerup powerup))
        {
            powerup.Deactivate();
            // GetEffect(powerup.GetPowerupType());
        }
    }

    // private void GetEffect(PowerupType type) 
    // {
    //     switch(type)
    //     {
    //         case PowerupType.Heal:
    //             playerController.HealUp();
    //             break;
    //         case PowerupType.SizeUp:
    //             playerController.SizeUp();
    //             break;
    //         case PowerupType.SizeDown:
    //             playerController.SizeDown();
    //             break;
    //         case PowerupType.Speed:
    //             playerController.SpeedUp();
    //             break;
    //         default:
    //             break;
    //     }
    // }
}
