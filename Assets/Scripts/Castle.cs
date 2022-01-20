using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    private Transform Transform;
    private SpriteRenderer Spr;
    private int CurrentSpr;
    [SerializeField]
    private Sprite[] sprites;
    public virtual void Start()
    {
        Transform = GetComponent<Transform>();
        Transform.position = new Vector3(Transform.position.x, Transform.position.y, 123);
        Spr = GetComponent<SpriteRenderer>();
    }
    
    public virtual void Spakdrag()
    {
        CurrentSpr = Random.Range(0,4);
        Spr.sprite = sprites[CurrentSpr];
        Transform.position = new Vector3(Transform.position.x, Transform.position.y, 122);
    }
    public virtual void Vanish()
    {
        Transform.position = new Vector3(Transform.position.x, Transform.position.y, 123);
    }
}
