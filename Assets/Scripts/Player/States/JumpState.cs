using UnityEngine;

public class JumpState : PlayerState
{
    public JumpState(PlayerController player) : base(player){ }

    public override void Enter()
    {
        Debug.Log("Entered jump state");
        player.Jump();
    }

    public override void Exit()
    {
        Debug.Log("Exited jump state");
    }

    public override void HandleInput(PlayerCommand input)
    {
        
    }

    public override void Update()
    { 
    }
}
