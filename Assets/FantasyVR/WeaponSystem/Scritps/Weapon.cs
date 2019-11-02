using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WeaponSystem
{
    [RequireComponent(typeof(Rigidbody))]
    public abstract class Weapon : MonoBehaviour
    {
        [SerializeField] protected Rigidbody m_rigidbody;
        private Vector3 lastVelocity;

        private void OnCollisionEnter(Collision collision)
        {
            if (lastVelocity.magnitude != 0)
            {
                OVRInput.SetControllerVibration(1 / lastVelocity.magnitude, Mathf.Clamp01(lastVelocity.magnitude), OVRInput.Controller.RTouch);
            }
        }
    }
}
