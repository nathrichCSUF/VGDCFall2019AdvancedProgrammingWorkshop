using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Project.GunSystem
{
    public abstract class GunBase : MonoBehaviour, IShootable
    {
        // Start is called before the first frame update
        public abstract void Shoot(float bulletSpeed);
    }
}

