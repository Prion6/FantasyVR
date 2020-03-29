using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public HumanBodyBones selectedPart;

    private Transform bodyPart;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        //bodyPart = anim.GetBoneTransform(selectedPart);
    }

    void LateUpdate()
    {
        //bodyPart.LookAt(target.position);
        //bodyPart.rotation = bodyPart.rotation * Quaternion.Euler(offset);
    }
}
