using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private float speedMovement = 7f;
    private void Update()
    {
        Vector2 inputVector = new Vector2(0f,0f);

        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y = +1;  
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y = -1;

        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x = +1;

        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1;

        }


         inputVector = inputVector.normalized;
        Vector3 inputDirection = new Vector3(inputVector.x,0,inputVector.y);

        transform.position += inputDirection * Time.deltaTime * speedMovement ;
    }

}
