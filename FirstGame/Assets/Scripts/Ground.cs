using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public AudioSource hazzardSound, bombSound;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hazzard"))
        {
            hazzardSound.Play();  
        }

        if (collision.gameObject.CompareTag("Bomb"))
        {
            bombSound.Play();
        }
    }
}
