﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackable : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int health;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void OnAttack(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
        else {
            Debug.Log(gameObject.name + " has been hit, now has " + health + " health left" );
        }
        
    }



    public void Die()
    {
        Debug.Log("SNAPPED OUT OF EXISTENCE.");
        Destroy(gameObject);
    }

}
