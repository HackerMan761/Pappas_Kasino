using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    Transform Transform;
    SpriteRenderer Spr;
    public virtual void Start()
    {
        Transform = GetComponent<Transform>();
        Transform.position = new Vector3(Transform.position.x, Transform.position.y, -16);
        Spr = GetComponent<SpriteRenderer>();
        print(Spr.isVisible);
    }
    
    public virtual void Spakdrag()
    {
        Transform.position = new Vector3(Transform.position.x, Transform.position.y, 0);
    }
}
