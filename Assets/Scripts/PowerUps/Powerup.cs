using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PowerupType
{
    Heal,
    Speed,
    SizeUp,
    SizeDown
}
public class Powerup : MonoBehaviour
{
    [SerializeField]protected PowerupType powerupType;
    private Collider col;

    private void Start() {
        col = GetComponent<Collider>();
    }

    public virtual void Deactivate()
    {
        EventManager.instance.ONOnPowerupTaken(powerupType);
        col.enabled = false;
        transform.localScale = Vector3.zero;
    }

    public virtual void Activate()
    {
        col.enabled = true;
        transform.localScale = Vector3.one;
    }

}
