using UnityEngine;

public class RunningState : PlayerState
{
    public RunningState(PlayerController player) : base(player)
    {}

    public override void Enter()
    {
        Debug.Log("Entered Running State");
    }

    public override void Exit()
    {
        Debug.Log("Exited Running State");
    }

    public override void HandleInput(PlayerCommand input)
    {
        Debug.Log("Exited Running State");
    }

    public override void Update()
    {
        player.Move();
    }
}
