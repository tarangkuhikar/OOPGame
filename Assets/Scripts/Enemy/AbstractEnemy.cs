using System.Collections;
using UnityEngine;

public abstract class AbstractEnemy : MonoBehaviour, IHitable
{
    [SerializeField]
    protected float health;
    public float Health
    {
        get => health;
        protected set
        {
            health = value;
            if (health <= 0)
            { Destroy(gameObject); }
        }
    }

    public void Hit(float Damage)
    {
        health -= Damage;
    }

}
