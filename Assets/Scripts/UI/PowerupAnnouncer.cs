using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerupAnnouncer : MonoBehaviour
{

    private TextMeshProUGUI announcementText;
    private void Start() 
    {
        announcementText = GetComponent<TextMeshProUGUI>();
        EventManager.instance.OnPowerupTaken += AnnouncePowerup;
        Disable(); 
    }

    private void AnnouncePowerup(PowerupType type)
    {
        announcementText.transform.localScale = Vector3.one;
        announcementText.text = $"{type} Powerup Taken!";
        Invoke(nameof(Disable),2f);
        // switch (type)
        // {
        //     case PowerupType.Heal:
        //         announcementText.text = "Heal Powerup Taken!";
        //         break;
        //     case PowerupType.Speed:
        //         announcementText.text = "Speed Powerup Taken!";
        //         break;
        //     case PowerupType.SizeUp:
        //         announcementText.text = "Size Up Powerup Taken!";
        //         break;
        //     case PowerupType.SizeDown:
        //         announcementText.text = "Size Down Powerup Taken!";
        //         break;
        //     default:
        //         break;
        // }
    }

    private void Disable()
    {
        announcementText.transform.localScale = Vector3.zero;
    }
}
