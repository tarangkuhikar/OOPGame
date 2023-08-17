using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController characterController;
    Rigidbody rigidBody;
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        rigidBody = GetComponent<Rigidbody>();
    }
    

}
