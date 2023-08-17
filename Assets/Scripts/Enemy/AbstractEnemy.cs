using System.Collections;
using UnityEngine;

public abstract class AbstractEnemy : MonoBehaviour, IHitable
{
    [SerializeField]
    protected float health;
    protected Transform player;
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
    protected void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public void Hit(float Damage)
    {
        health -= Damage;
    }

}
