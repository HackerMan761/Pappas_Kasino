using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spakanim : MonoBehaviour
{
    public Animator anim;
    public Spak spk;
    public void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void Update()
    {
        if (spk.anim)
        {
            anim.SetBool("draspak", true);
        }
        else
        {
            anim.SetBool("draspak", false);
        }
    }
}

