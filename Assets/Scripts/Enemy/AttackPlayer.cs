using System.Collections;
using UnityEngine;

//Inheritance
public class AttackPlayer : AbstractEnemy
{
    [SerializeField]
    float chaseSpeed = 1;
    bool isAttackingPlayer;
    Vector3 moveDirection;
    PlayerController controller;
    private void Update()
    {
        if (isAttackingPlayer)
        {
            transform.LookAt(player);
            moveDirection = (player.position - transform.position).normalized;
            moveDirection.y = 0;
            transform.position += chaseSpeed * Time.deltaTime * moveDirection;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out controller))
        {
            Debug.Log("Hit");
            controller.Hit(10);
        }
    }
    //Override
    public override void Hit(float Damage)
    {
        base.Hit(Damage);
        isAttackingPlayer = true;
    }
}
