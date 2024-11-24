using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] InputHandler inputHandler;
    [SerializeField] float moveSpeed;

    private void FixedUpdate()
    {
        HandlePlayerMovement();
    }

    private void HandlePlayerMovement()
    {
        Vector2 inputVector = inputHandler.GetMovementVectorNormalized();

        Vector3 moveDirection = new Vector3(inputVector.x, inputVector.y, 0f);
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
