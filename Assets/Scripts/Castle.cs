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
    public virtual void Start() //referenser
    {
        Transform = GetComponent<Transform>();
        Transform.position = new Vector3(Transform.position.x, Transform.position.y, 123);
        Spr = GetComponent<SpriteRenderer>();
        spakgrej.spel = false;
    }
    public virtual void Spakdrag() //väljer en random ikon och visar sig på maskinen
    {
        if (spakgrej.spel)
        {
            CurrentSpr = Random.Range(0,4);
            Spr.sprite = sprites[CurrentSpr];
            Transform.position = new Vector3(Transform.position.x, Transform.position.y, 122);
        }
    }
    public virtual void Vanish() //gömmer ikonen
    {
        Transform.position = new Vector3(Transform.position.x, Transform.position.y, 123);
    }
}
