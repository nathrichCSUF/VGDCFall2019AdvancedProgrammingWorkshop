using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.GunSystem
{
    public class Pistol : GunBase
    {
        public GameObject bullet;
        // Start is called before the first frame update
        public override void Shoot(float bulletSpeed)
        {
           GameObject newBullet =  Instantiate(bullet, new Vector2(transform.position.x, transform.position.y),transform.rotation);
           newBullet.GetComponent<Bullet>().SetSpeed(bulletSpeed);   
        }
    }
}
