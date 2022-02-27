using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    [SerializeField] GameObject Projectile;
    [SerializeField] float ProjectileSpeed = 4f;
    // Start is called before the first frame update

    Vector3 VectorOffSett;
    
     
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
        VectorOffSett = new Vector3(0f,0.47f,0f);
        
        if(isFiring)
        {
            GameObject instance = Instantiate(Projectile, transform.position+VectorOffSett, Quaternion.identity);
            Rigidbody2D rb = instance.GetComponent<Rigidbody2D>();
            rb.velocity = transform.up * ProjectileSpeed;
            isFiring = false;
        }
    
    }

    

    
     
}
