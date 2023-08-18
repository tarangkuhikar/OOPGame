using System.Collections;
using UnityEngine;

public class RunAwayCreature : AbstractEnemy
{
    bool isRunningAway=false;
    float runTime = 7;
    float t = 0;
    Vector2 runAwayDirection;
    [SerializeField]
    private float moveSpeed;

    private void Start()
    {
        moveSpeed = 1;
        runAwayDirection = Random.insideUnitCircle.normalized;
    }

    public override void Hit(float Damage)
    {
        base.Hit(Damage);
        isRunningAway = true;
    }

    private void Update()
    {
        if (isRunningAway)
        {
            moveSpeed = 5;
            t += Time.deltaTime;
            if (t > runTime)
            {
                moveSpeed = 1;
                t = 0;
                isRunningAway = false;
                runAwayDirection = Random.insideUnitCircle.normalized;
            }
        }
        transform.position += moveSpeed * Time.deltaTime * new Vector3(runAwayDirection.x, 0, runAwayDirection.y);
    }
}
