using System;
using Unity.Android.Gradle.Manifest;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public CharacterController characterController;
    [HideInInspector] public PlayerState currentState { get; private set; }
    [SerializeField] private Transform groundCheckPos;
    [SerializeField] private float groundCheckRadius = 0.2f;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpSpeed = 5f;
    [SerializeField] private float gravity = -9.81f;
    private Vector3 directionToApplyForce;
    private void Start()
    {
        ChangeState(new IdleState(this));
    }
    public void HandleInput(PlayerCommand input)
    {
        currentState?.HandleInput(input);
    }
    private void Update()
    {
        currentState.Update();
    }
    public void ChangeState(PlayerState newState)
    {

        if (currentState == newState) return;
        currentState?.Exit();
        currentState = newState;
        currentState?.Enter();
    }
    public void Move()
    {
        directionToApplyForce = moveSpeed * Time.deltaTime * Vector3.forward;
        ApplyGravity();
        characterController.Move(directionToApplyForce);
    }
    public void Jump()
    {
        directionToApplyForce = jumpSpeed * Vector3.up;
        if (characterController.isGrounded)
        {
            characterController.Move(directionToApplyForce);
        }
    }
    public void ApplyGravity()
    {
        if (characterController.isGrounded && directionToApplyForce.y < 0f)
            directionToApplyForce.y = -2f;

        directionToApplyForce.y += gravity * Time.deltaTime;
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundCheckPos.position, groundCheckRadius);
    }
}