using UnityEngine;

public abstract class AbstractGun:MonoBehaviour
{
    [SerializeField]
    protected Bullet bullet;

    public abstract void Fire();
}