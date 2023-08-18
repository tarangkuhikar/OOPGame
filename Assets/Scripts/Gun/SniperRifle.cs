using System.Collections;
using UnityEngine;

public class SniperRifle : AbstractGun
{
    public override void Fire()
    {
        Instantiate(bullet,gameObject.transform.position,Quaternion.identity).OnFire(5,transform.up);
    }
}
