using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazzard : MonoBehaviour
{
    Vector3 rotation;
    private void Start()
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
        if(!collision.gameObject.CompareTag("Hazzard") || !collision.gameObject.CompareTag("Bomba") || !collision.gameObject.CompareTag("Coin"))
        {
            Destroy(gameObject);
        }
        
    }

}
