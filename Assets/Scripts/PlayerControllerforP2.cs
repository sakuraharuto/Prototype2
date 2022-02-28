using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerControllerforP2 : MonoBehaviour
{   
    float moveSpeed = 5f;
    Vector2 moveInput;
    Rigidbody2D rb2d;

    shooterforP2 Shooter;
    public static int BulletAmountforP2 = 0;
    public static int Score = 0;
    public static int health = 3;

   // [SerializeField] GameObject Projectile;
    
   

    void Awake() 
    {
      Shooter = GetComponent<shooterforP2>();   
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
        //GameSucess();
        //Gamelose();
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
            if(BulletAmountforP2 > 0)
            {
                Shooter.isFiringforP2 = true;
                //Debug.Log("Firing!");
                PlayerControllerforP2.BulletAmountforP2 --;
            }
        }

    }

    //void GameSucess()
    //{
       // if(Score == 5)
       // {
        //    Debug.Log("win!!!!!!!!!!!");
        //}
    //}

   // void Gamelose()
   // {
      //  if(health == 0)
        //{
        //    SceneManager.LoadScene(0);
       // }
   // }

        
}
