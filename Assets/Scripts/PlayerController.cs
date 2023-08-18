using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : AbstractEnemy
{
    CharacterController characterController;

    Vector3 moveDirection;
    [SerializeField]
    private float speed;
    [SerializeField]
    float lookSensitivity;
    Vector2 lookDirection;

    [SerializeField]
    AbstractGun[] availableGuns;
    //Polymorphism
    AbstractGun playerGun;
    int currentGunIndex = 0;
    public override void Awake()
    {
        characterController = GetComponent<CharacterController>();
        playerGun = availableGuns[currentGunIndex];
    }
    public void OnMove(InputValue value)
    {
        moveDirection = value.Get<Vector2>();
    }
    public void OnFire()
    {
        playerGun.Fire();
    }

    public void OnGunChanged()
    {
        currentGunIndex++;
        currentGunIndex %= availableGuns.Length;
        playerGun = availableGuns[currentGunIndex];
        Debug.Log(playerGun.GetType());
    }

    public void Update()
    {
        characterController.Move(speed * Time.deltaTime * (moveDirection.x * transform.right + moveDirection.y * transform.forward));
        transform.Rotate(lookSensitivity * Time.deltaTime * lookDirection);
        if (!characterController.isGrounded)
        {
            characterController.Move(9.8f * Time.deltaTime * -transform.up);
        }
    }


    public void OnLook(InputValue value)
    {
        lookDirection.y = value.Get<Vector2>().x;
    }

}
