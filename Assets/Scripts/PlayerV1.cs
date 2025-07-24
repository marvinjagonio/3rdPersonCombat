using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerV1 : MonoBehaviour
{
    public InputActionAsset InputActions;

    private InputAction p_moveAction;
    private InputAction p_lookAction;
    private InputAction p_jumpAction;

    private Vector2 p_moveAmt;
    private Vector2 p_lookAmt;
    private Animator p_animator;
    private Rigidbody p_rigidbody;

    public float WalkSpeed = 5;
    public float RotateSpeed = 5;
    public float JumpSpeed = 5;

    private void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();
    }

    private void OnDisable()
    {
        InputActions.FindActionMap("Player").Disable();
    }

    private void Awake()
    {
        p_moveAction = InputSystem.actions.FindAction("Move");
        p_lookAction = InputSystem.actions.FindAction("Look");
        p_jumpAction = InputSystem.actions.FindAction("Jump");

        p_animator = GetComponent<Animator>();
        p_rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        p_moveAmt = p_moveAction.ReadValue<Vector2>();
        p_lookAmt = p_lookAction.ReadValue<Vector2>();

        if(p_jumpAction.IsPressed())
        {

        }
    }
}
