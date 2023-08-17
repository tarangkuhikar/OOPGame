using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    CharacterController characterController;

    Vector3 moveDirection;
    [SerializeField]
    private float speed;
    [SerializeField]
    float lookSensitivity;
    Vector2 lookDirection;
    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    public void OnMove(InputValue value)
    {
        moveDirection = value.Get<Vector2>();
    }

    public void Update()
    {
        characterController.Move(speed * Time.deltaTime * (moveDirection.x * transform.right + moveDirection.y * transform.forward));
        transform.Rotate(lookSensitivity*Time.deltaTime * lookDirection);
    }
    public void OnLook(InputValue value)
    {
        lookDirection.y = value.Get<Vector2>().x;
    }

}
