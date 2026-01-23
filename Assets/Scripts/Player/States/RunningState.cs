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
        if (input == PlayerCommand.Jump)
        {
            var airborneState = new AirborneState(player);
            SwitchStates(airborneState);
            SetSubState(new JumpState(player));
        }
    }

    public override void Update()
    {
        player.Move();
        base.Update();
    }
}
