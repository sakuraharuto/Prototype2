using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooterForP2 : MonoBehaviour
{
    [SerializeField] GameObject Projectile;
    [SerializeField] float ProjectileSpeed = 4f;
    // Start is called before the first frame update
     
    public bool isFiring;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shooting();
    }

    //private void OnCollider2D(Collider2D other) 
    //{
     //   Destroy(gameObject);
    //}

    void shooting()
    {
        
        if(isFiring)
        {
            GameObject instance = Instantiate(Projectile, transform.position, Quaternion.identity);
            Rigidbody2D rb = instance.GetComponent<Rigidbody2D>();
            rb.velocity = -transform.up * ProjectileSpeed;
            isFiring = false;
        }
    
    }

    

    
     
}
