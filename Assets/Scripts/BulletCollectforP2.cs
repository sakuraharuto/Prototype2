using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollectforP2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.transform.tag == "Player")
        {
            PlayerControllerforP2.BulletAmountforP2 = 1 ;
            Destroy(gameObject);
            
        }
    }
}