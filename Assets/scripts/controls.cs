using UnityEngine;
using UnityEngine.InputSystem;

public class controls : MonoBehaviour
{
    int speed = 10;
    int constraint = 8;
    InputAction moveAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        if (moveValue.x < 0 && transform.position.x > -constraint )
        {
            transform.position -= speed* transform.right* Time.deltaTime;
        }
        if (moveValue.x > 0 && transform.position.x < constraint )
        {
            transform.position += speed* transform.right* Time.deltaTime;
        }
        // Debug.Log(moveValue);
    }
}
