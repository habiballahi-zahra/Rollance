using UnityEngine;

public class InputBallController : MonoBehaviour
{
    [HideInInspector] public Vector3 ballDirection;
    private bool isMovingSideways = false;

    void Start()
    {
        ballDirection = Vector3.forward;
    }

    void Update()
    {
        HandleBallInput();
    }

    private void HandleBallInput() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            ToggleDirection(Vector3.left);

        }
        else if (Input.GetMouseButtonDown(1))
        {
        ToggleDirection(Vector3.right); 
        }

    
    }

    private void ToggleDirection(Vector3 newDirection) 
    
    {
        if (isMovingSideways) 
        {
            ballDirection = Vector3.forward;
        }
        else
        {
            ballDirection = newDirection;
        }
        isMovingSideways = !isMovingSideways;
    }
}
