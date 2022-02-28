using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{   
    [SerializeField] float moveSpeed = 5f;
    Vector2 moveInput;
    Rigidbody2D rb2d;

    shooter Shooter;
    ScoreRecord scorerecord;
    PlayerControllerforP2 P2;
    public static int BulletAmount = 0;
    public static int Score = 0;

    public static  int WholeScore;

    

   // [SerializeField] GameObject Projectile;
    
   

    void Awake() 
    {
      Shooter = GetComponent<shooter>();  
      scorerecord = GetComponent <ScoreRecord>(); 
      P2 = GetComponent <PlayerControllerforP2>(); 
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
        GameSucess();
        Counting();
        //Gamelose();
        
        Debug.Log(WholeScore);
        
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
            if(BulletAmount > 0)
            {
                Shooter.isFiring = true;
                //Debug.Log("Firing!");
                PlayerController.BulletAmount --;
            }
        }

    }

    void GameSucess()
    {
        if(WholeScore == 5)
        {
            Debug.Log("win!!!!!!!!!!!");
        }
    }

    //void Gamelose()
   // {   if(scorerecord != null)
        //{
           // if(scorerecord.health == false )
           // {
             //   Score--;
             //   scorerecord.health = true;
           // }
       // }
    //}

    void Counting()
    {
        WholeScore = PlayerControllerforP2.Score + Score;
    }

        
}
