using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Zeke
public class Castle : MonoBehaviour
{
    private Transform Transform;
    private SpriteRenderer Spr;
    private int CurrentSpr;
    [SerializeField]
    private Sprite[] sprites;
    public Spak spakgrej;
    public Animator anim;
    public virtual void Start()
    {
        Transform = GetComponent<Transform>();
        Transform.position = new Vector3(Transform.position.x, Transform.position.y, 123);
        Spr = GetComponent<SpriteRenderer>();
        spakgrej.spel = false;
    }
    public virtual void Spakdrag()
    {
        if (spakgrej.spel)
        {
            CurrentSpr = Random.Range(0,4);
            Spr.sprite = sprites[CurrentSpr];
            Transform.position = new Vector3(Transform.position.x, Transform.position.y, 122);
        }
    }
    public virtual void Vanish()
    {
        Transform.position = new Vector3(Transform.position.x, Transform.position.y, 123);
    }
}
