using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreRecord : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.transform.tag == "Basket")
        {
            PlayerController.Score ++ ;
            Destroy(gameObject);
            
        }

        if(collision.transform.tag == "HealthBar")
        {
            PlayerController.health --;
            Destroy(gameObject);
        }
        
        if(collision.transform.tag =="Player")
        {
            Destroy(gameObject);
        }

    }
}
