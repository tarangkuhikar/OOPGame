using System.Collections;
using UnityEngine;

public abstract class AbstractEnemy : MonoBehaviour, IHitable
{
    [SerializeField]
    protected float health;
    protected Transform player;

    //Encapsulation
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
    public virtual void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public virtual void Hit(float Damage)
    {
        Health -= Damage;
    }

}
