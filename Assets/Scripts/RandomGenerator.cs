using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{
    SpriteRenderer SpriteRenderer;
    Sprite new_sprite;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
            var Pposition = new Vector3(Random.Range(-100f, 10.0f), Random.Range(-100.0f, 10.0f),0);
            GameObject one = new GameObject();
            one.name = "one";
            one.transform.position = Pposition ;
            SpriteRenderer = one.AddComponent<SpriteRenderer>();
            SpriteRenderer.sprite = new_sprite; 
            print (Pposition); 
            
            
    }

}
