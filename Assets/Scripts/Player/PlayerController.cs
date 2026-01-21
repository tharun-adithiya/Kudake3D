using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [HideInInspector]public PlayerState currentState { get; private set; }
    [SerializeField] private float moveSpeed=5f;
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
        transform.position += moveSpeed * Time.deltaTime * Vector3.forward;
    }
}
