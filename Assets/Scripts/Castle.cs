using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    private Transform Transform;
    private SpriteRenderer Spr;
    private int CurrentSpr;
    private Sprite[] sprites;
    private string spriteNames = "Coin";
    public virtual void Start()
    {
        Transform = GetComponent<Transform>();
        Transform.position = new Vector3(Transform.position.x, Transform.position.y, -16);
        Spr = GetComponent<SpriteRenderer>();
        sprites = Resources.LoadAll<Sprite>(spriteNames);
    }
    
    public virtual void Spakdrag()
    {
        CurrentSpr += 1;
        if (CurrentSpr > sprites.Length - 1)
        {
            CurrentSpr = 0;
        }
        //Spr.sprite = sprites[CurrentSpr];
        Transform.position = new Vector3(Transform.position.x, Transform.position.y, 0);
    }
}
