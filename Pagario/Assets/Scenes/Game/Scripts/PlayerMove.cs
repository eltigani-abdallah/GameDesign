using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMove : MonoBehaviour
{
    private Rigidbody PlayerRb;
    private Vector2 MoveInput;
    [SerializeField] private float MoveSpeed = 10f;
    private void Awake()
    {
        PlayerRb = GetComponent<Rigidbody>();
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        MoveInput = ctx.ReadValue<Vector2>();
    }

    void Update()
    {
        PlayerRb.linearVelocity = new Vector2(MoveInput.x * MoveSpeed,  MoveInput.y * MoveSpeed);
    }
}
