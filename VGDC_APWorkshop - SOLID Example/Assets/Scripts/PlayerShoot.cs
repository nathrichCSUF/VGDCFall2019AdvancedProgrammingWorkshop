using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.GunSystem
{
    public class PlayerShoot : MonoBehaviour
    {
        public float pistolBulletSpeed = 25f;
        IShootable shootable;
        // Update is called once per frame
        private void Start()
        {
             shootable = gameObject.GetComponent<IShootable>();
        }
        void Update()
        {
            if (Input.anyKeyDown)
            {
                shootable.Shoot(pistolBulletSpeed);
            }
        }
    }
}
