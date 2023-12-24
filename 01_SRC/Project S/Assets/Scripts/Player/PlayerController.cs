using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public GameManager gameManager;
    private float playerMovementSpeed =  5f;
    private bool isEnterPressed;
    
    [SerializeField]
    private Rigidbody2D rbPlayer;



    Vector2 playerMovement;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Gets the movement of the player by pressing the controls.
    void InitPlayerMovements()
    {
        playerMovement.x = Input.GetAxisRaw("Horizontal");
        playerMovement.y = Input.GetAxisRaw("Vertical");
    }

// Moves the player by getting the postition of the player with the computation
    void InitRbPlayer()
    {
        rbPlayer.MovePosition(rbPlayer.position + playerMovement * playerMovementSpeed * Time.fixedDeltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        InitPlayerMovements();

        isEnterPressed = false;
        if (Input.GetKey(KeyCode.Return))
        {
            isEnterPressed = true;
        }


    }


    
    void FixedUpdate()
    {
        InitRbPlayer();
    }


    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject == gameManager.storeManager.npcStorekeeper)
        {
            if (isEnterPressed)
            {
                gameManager.OpenStore();
            }

        }
    }


}
