using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    Rigidbody rigidBody;
    IHitable hitable;
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    //Abstraction
    public void OnFire(float force, Vector3 direction)
    {
        rigidBody.AddForce(force * direction, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out hitable))
        {
            hitable.Hit(10);
        }
        Destroy(gameObject);
    }
}
