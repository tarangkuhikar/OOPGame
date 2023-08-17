using System.Collections;
using UnityEngine;

public class AttackPlayer : AbstractEnemy
{
    [SerializeField]
    float chaseSpeed = 1;

    Vector3 moveDirection;
    private void Update()
    {
        transform.LookAt(player);
        moveDirection = (player.position - transform.position).normalized;
        moveDirection.y = 0;
        transform.position += chaseSpeed * Time.deltaTime * moveDirection;
    }
}
