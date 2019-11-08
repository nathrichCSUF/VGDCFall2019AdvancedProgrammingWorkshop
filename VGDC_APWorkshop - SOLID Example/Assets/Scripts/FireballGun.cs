using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.GunSystem
{
    
    public class FireballGun : GunBase
    {
        public GameObject bullet;
        // Start is called before the first frame update
        public override void Shoot(float bulletSpeed)
        {
            StartCoroutine(ShootFireballs(bulletSpeed));
        }
        IEnumerator ShootFireballs(float bulletSpeed)
        {

            GameObject newBullet = Instantiate(bullet, new Vector2(transform.position.x, transform.position.y), transform.rotation);
            newBullet.GetComponent<Bullet>().SetSpeed(bulletSpeed);
            yield return new WaitForSeconds(1f);
            GameObject newBullet2 = Instantiate(bullet, new Vector2(transform.position.x, transform.position.y), transform.rotation);
            newBullet2.GetComponent<Bullet>().SetSpeed(bulletSpeed);
        }
    }
}
