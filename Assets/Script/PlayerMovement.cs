using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

   

    // Update is called once per frame
    void Update()
    {
        // mendapatkan input dari pemain contohnya wasd 
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        //menghitung pergerakan pemain
        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0f);
        Vector3 moveVelocity  = moveDirection.normalized * moveSpeed * Time.deltaTime;
            
        // menggerakkan pemain
        transform.Translate(moveVelocity);
    }

}
