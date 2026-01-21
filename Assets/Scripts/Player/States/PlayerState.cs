using UnityEngine;

public abstract class PlayerState
{
    public PlayerController player;
    public PlayerState(PlayerController player)
    { this.player = player; }
    public abstract void Enter();
    public abstract void HandleInput(PlayerCommand input);
    public abstract void Update();
    public abstract void Exit();

}
