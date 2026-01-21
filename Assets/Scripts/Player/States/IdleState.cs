using UnityEngine;

public class IdleState : PlayerState
{
    public IdleState(PlayerController player):base(player) { }

    public override void Enter()
    { Debug.Log("Entered Idle State"); }

    public override void HandleInput(PlayerCommand input)
    {
        if (input == PlayerCommand.Start)
        {
            player.ChangeState(new RunningState(player));      
        }
    }

    public override void Update()
    {  }
    public override void Exit()
    { Debug.Log("Exited Idle State"); }
}
