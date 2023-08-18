using System.Collections;
using UnityEngine;

public class SemiMachineGun : AbstractGun
{
    public override void Fire()
    {
        Instantiate(bullet,transform.position, Quaternion.identity).OnFire(0.5f,transform.up);
    }
}
