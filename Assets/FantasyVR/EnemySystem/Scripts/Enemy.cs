using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool alive = true;

    [ContextMenu("Kill")]
    public void Kill()
    {
        if (alive)
        {
            GetComponent<Animator>().enabled = false;
            alive = false;

            transform.SetLayer(LayerMask.NameToLayer("Body"));
        }
    }
}

public static class TransformExtensions
{
    public static void SetLayer(this Transform trans, int layer)
    {
        trans.gameObject.layer = layer;
        foreach (Transform child in trans)
            child.SetLayer(layer);
    }
}
