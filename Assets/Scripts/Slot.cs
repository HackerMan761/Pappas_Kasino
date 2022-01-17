using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private IEnumerator coroutine;
    Transform Transform;
    SpriteRenderer Spr;
    void Start()
    {
        Transform = GetComponent<Transform>();
        Transform.position = new Vector3(Transform.position.x, Transform.position.y - 16);
        Spr = GetComponent<SpriteRenderer>();
        print(Spr.isVisible);
        coroutine = WaitAndPrint(2.0f);
    }

    private IEnumerator WaitAndPrint(float v)
    {
        throw new NotImplementedException();
    }

    void Update()
        {
         if (Input.GetKeyDown(KeyCode.G))
        {
            StartCoroutine(coroutine);
        }
        }
    void Spakdrag()
        {

        }
}