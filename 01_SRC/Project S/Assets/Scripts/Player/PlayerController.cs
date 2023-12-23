using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float playerMovementSpeed =  5f;
    
    [SerializeField]
    private Rigidbody2D rbPlayer;

    Vector2 playerMovement;
    // Start is called before the first frame update
    void Start()
    {

    }

    void InitPlayerMovements()
    {
        playerMovement.x = Input.GetAxisRaw("Horizontal");
        playerMovement.y = Input.GetAxisRaw("Vertical");
    }

    void InitRbPlayer()
    {
        rbPlayer.MovePosition(rbPlayer.position + playerMovement * playerMovementSpeed * Time.fixedDeltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        InitPlayerMovements();
    }


    
    void FixedUpdate()
    {
        InitRbPlayer();
    }
}
