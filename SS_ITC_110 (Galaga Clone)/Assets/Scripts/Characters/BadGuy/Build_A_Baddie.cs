using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build_A_Baddie : MonoBehaviour
{
    //Put your own functions here!
    public BadGuyBrain badGuyBrain;

    private void Start()
    {
        badGuyBrain = GetComponent<BadGuyBrain>();
    }

    private void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            badGuyBrain.player.GetComponent<CharacterBrain>().health++;
            badGuyBrain.Despawn();
        }
    }
}
