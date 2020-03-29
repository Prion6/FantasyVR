using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace WeaponSystem
{
    public class Heavy_Rifle : Weapon
    {
        [SerializeField]
        protected OVRInput.Controller m_controller;

        public Transform shootPoint;

        public GameObject bullet_prefab;

        public float shootCD = 0.25f;
        private float nextShootIn = 0;

        public bool autoShoot;

        public bool isRight;

        public UnityEvent onShoot;

        private void Update()
        {
            if (autoShoot)
            {
                if (Time.time >= nextShootIn)
                {
                    Shoot();
                    return;
                }
            }

            if (isRight)
            {
                if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
                {
                    if (Time.time >= nextShootIn)
                    {
                        Shoot();
                    }
                }
            }
            else
            {
                if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
                {
                    if (Time.time >= nextShootIn)
                    {
                        Shoot();
                    }
                }
            }
        }

        private void Shoot()
        {
            GameObject bullet = Instantiate(bullet_prefab);
            bullet.transform.position = shootPoint.position;
            bullet.transform.rotation = shootPoint.rotation;

            nextShootIn = Time.time + shootCD;
            onShoot.Invoke();
            FindObjectOfType<SoundManager>().Play("normal attack");


            StartCoroutine(Vibration());
        }

        private IEnumerator Vibration()
        {
            OVRInput.SetControllerVibration(0.5f, 1, m_controller);

            yield return new WaitForSeconds(Time.deltaTime);

            OVRInput.SetControllerVibration(0, 0, m_controller);
        }
    }

}