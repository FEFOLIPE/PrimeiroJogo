using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource coinSound;

    Vector3 rotation;

    public void Start()
    {
        var xRotation = Random.Range(-10, 10);
        rotation = new Vector3(xRotation, 0);
    }
    private void Update()
    {
        transform.Rotate(rotation);
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);           
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            coinSound.Play();
        }
    }
}
