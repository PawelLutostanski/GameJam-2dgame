﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public const float health_max = 12;
    public float health_now;
    GameObject itself;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    void TakeDmg(float dmg_given)
    {
        health_now -= dmg_given;
        if (health_now < 0)
        {
            Destroy(itself);
        }

    }
}
