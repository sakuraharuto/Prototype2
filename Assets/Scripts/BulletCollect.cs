using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.transform.tag == "Player")
        {
            PlayerController.BulletAmount = 1 ;
            Destroy(gameObject);
            
        }
    }
}
