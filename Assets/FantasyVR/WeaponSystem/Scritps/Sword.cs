using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WeaponSystem
{
    public class Sword : Weapon
    {
        public float minDamageVelocity = 50;
        public float maxDamageVelocity = 500;

        private void Update()
        {
            return;
            if (m_rigidbody.velocity.magnitude + m_rigidbody.angularVelocity.magnitude >= 5)
            {
                OVRInput.SetControllerVibration(1,1, OVRInput.Controller.RTouch);
            }
            else
            {
                OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
            }
        }
    }
}
