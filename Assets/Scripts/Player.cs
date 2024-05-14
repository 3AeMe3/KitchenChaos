using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private float speedMovement = 7f;
    [SerializeField] GameInput gameInput;

    private bool isWalking; 

    private void Update()
    {

        Vector2 inputVector = gameInput.GetMovementVectorNormalized();
        Vector3 moveDir = new Vector3(inputVector.x ,0,inputVector.y);

        transform.position += moveDir * Time.deltaTime * speedMovement;

        isWalking = moveDir != Vector3.zero;

        float rotateSpeed = 10f;
        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * rotateSpeed);

    }


    public bool IsWalking()
    {
        return isWalking;
    }

}
