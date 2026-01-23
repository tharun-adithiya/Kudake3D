using UnityEngine;

public class AirborneState : PlayerState
{
    public AirborneState(PlayerController player) : base(player) { }
    public override void Enter()
    {   
    }

    public override void Exit()
    {   
    }

    public override void HandleInput(PlayerCommand input)
    {
    }

    public override void Update()
    {
        player.ApplyGravity();
        player.Move();
        if (player.characterController.isGrounded) 
        { 
            SwitchStates(new RunningState(player)); 
            return; 
        }
        base.Update();
    }
}
