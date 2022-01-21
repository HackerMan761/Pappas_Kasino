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
    public Spak spakgrej;
    private Animator anim;
    public virtual void Start()
    {
        Transform = GetComponent<Transform>();
        Transform.position = new Vector3(Transform.position.x, Transform.position.y, 123);
        Spr = GetComponent<SpriteRenderer>();
    }
    public virtual void Spakdrag()
    {
        if (spakgrej.spel)
        {
            anim.SetBool("Knapptryck", true);
            CurrentSpr = Random.Range(0,3);
            Spr.sprite = sprites[CurrentSpr];
            Transform.position = new Vector3(Transform.position.x, Transform.position.y, 122);
        }
        else
        {
            anim.SetBool("Knapptryck", false);
        }


    }
    public virtual void Vanish()
    {
        Transform.position = new Vector3(Transform.position.x, Transform.position.y, 123);
    }
}
