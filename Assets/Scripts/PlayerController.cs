using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{   
    [SerializeField] float moveSpeed = 5f;
    Vector2 moveInput;
    Rigidbody2D rb2d;

    shooter Shooter;
    

   // [SerializeField] GameObject Projectile;
    
   

    void Awake() 
    {
      Shooter = GetComponent<shooter>();   
    }
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //var p1 = PlayerInput.Instantiate(prefab: Player, controlScheme: "KeyboardLeft", device: Keyboard.current);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void OnMovement(InputValue value){
        moveInput = value.Get<Vector2>();
        //Debug.Log(moveInput);
    }

    void PlayerMove(){
        Vector2 playerVelocity = new Vector2(moveInput.x * moveSpeed, moveInput.y * moveSpeed);
       rb2d.velocity = playerVelocity;
    }

    void OnFire(InputValue value)
    {
        if(Shooter != null)
        {
            
                   Shooter.isFiring = true;
                    Debug.Log("Firing!");
                    

                
        }
    }
        

        
}
