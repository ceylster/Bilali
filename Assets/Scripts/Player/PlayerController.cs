using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isRunning;

    private PlayerAnimation playerAnimation;
    private PlayerHealth playerHealth;
    private PlayerMovement playerMovement;
    private PowerupHandler powerupHandler;
    
    
    // Start is called before the first frame update
    void Start()
    { 
        playerHealth = GetComponent<PlayerHealth>();
        playerAnimation = GetComponent<PlayerAnimation>();
        playerMovement = GetComponent<PlayerMovement>();
        powerupHandler = GetComponent<PowerupHandler>();
        EventManager.instance.OnPowerupTaken += OnPowerupTaken;
    }

    private void Update() 
    {
        // var horizontal = Input.GetAxis("Horizontal");
        // var vertical = Input.GetAxis("Vertical");
        // playerAnimation.VerticalMovement();
        // if(horizontal != 0)
        // {
        //     playerMovement.MoveHorizontal(horizontal);
        // }
        // if(vertical != 0)
        // {
        //     playerMovement.MoveVertical(vertical);
        // }
        var forwardInput = Input.GetKey(KeyCode.W) ? Input.GetKey(KeyCode.S) ? 0 : 1 : Input.GetKey(KeyCode.S) ? -1 : 0;
        var sideInput = Input.GetKey(KeyCode.D) ? Input.GetKey(KeyCode.A) ? 0 : 1 : Input.GetKey(KeyCode.A) ? -1 : 0;
        var finalInput = new Vector3(sideInput, 0, forwardInput);
        if(Mathf.Abs(sideInput) >= 1 && Mathf.Abs(forwardInput) >= 1)
        {
            finalInput *= 0.75f;
        }
        playerMovement.Move(finalInput);
        playerAnimation.SetMovement(finalInput);
    }

    private void OnPowerupTaken(PowerupType type)
    {
        switch (type)
        {
            case PowerupType.Heal:
                playerHealth.HealUp();
                break;
            case PowerupType.Speed:
                playerMovement.SpeedUp();
                break;
            case PowerupType.SizeUp:
                transform.localScale = Vector3.one * 2f;
                break;
            case PowerupType.SizeDown:
                transform.localScale = Vector3.one / 2f;
                break;
        }
    }

    public void HealUp()
    {
        playerHealth.HealUp();
    }

    public void SizeUp()
    {
        transform.localScale = Vector3.one * 2f;
    }

    public void SizeDown()
    {
        transform.localScale = Vector3.one / 2f;
    }

    public void SpeedUp()
    {
        playerMovement.SpeedUp();
    }


}
