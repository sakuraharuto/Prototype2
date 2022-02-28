using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreRecordforP2 : MonoBehaviour
{
    //public bool health;
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.transform.tag == "Basket")
        {
            PlayerControllerforP2.Score ++ ;
            Destroy(gameObject);
            
        }

        if(collision.transform.tag == "HealthBar")
        {
            PlayerControllerforP2.Score -- ;
            Destroy(gameObject);
        }
        
        if(collision.transform.tag =="Player")
        {
            Destroy(gameObject);
        }

    }
}

