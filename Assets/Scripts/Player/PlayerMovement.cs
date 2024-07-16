using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 15.0f;
    // public float horizontalInput;
    // public float verticalInput;

    private Vector3 currentVelocity;
    [SerializeField]private float rotateSpeed;
    void Start()
    {

    }

    public void Move(Vector3 direction)
    {
        currentVelocity = direction;
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
        if(direction != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotateSpeed * Time.deltaTime);
        }
    }
    public void SpeedUp()
    {
        speed *= 2f;
    }
    // public void MoveHorizontal(float horizontal)
    // {
    //     horizontalInput = horizontal;
    //     transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    // }

    // public void MoveVertical(float vertical)
    // {
    //     verticalInput = vertical;
    //     transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    // }
}
