using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{
    [SerializeField] private InputBallController inputBallController;
    [SerializeField] private float ballMovementSpeed = 5f;

   
    
    void Update()
    {
        MoveBall();
    }

    private void MoveBall() 
    {
        transform.position += inputBallController.ballDirection * ballMovementSpeed * Time.deltaTime;
    }
}
