using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(Rigidbody))]
public class CustomInputSystem : MonoBehaviour
{
    private Rigidbody sphereRB;
    private PlayerInput playerInput;
    PlayerInputActions playerInputActions;

    private void Awake()
    {
        sphereRB = GetComponent<Rigidbody>();   
        playerInput = GetComponent<PlayerInput>();

        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        playerInputActions.Player.Jump.performed += Jump;
       
    }

    private void FixedUpdate()
    {
        Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();
        float speed = 1f;
        sphereRB.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
    }


    public void Jump(InputAction.CallbackContext context)
    {
        if(context.performed)
            sphereRB.AddForce(Vector3.up * 5f, ForceMode.Impulse);
    } 
}
