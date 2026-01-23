using Unity.VisualScripting;
using UnityEngine;

public abstract class PlayerState
{
    public PlayerController player;
    protected PlayerState superState;
    protected PlayerState subState;
    public PlayerState(PlayerController player)
    { this.player = player; }
    public virtual void Enter() { }
    public virtual void HandleInput(PlayerCommand input){}
    public virtual void Update(){}
    public virtual void Exit(){}
    protected void SetSuperState(PlayerState newSuperState)=>superState = newSuperState;
    

    protected void SetSubState(PlayerState newSubState)
    {
        subState=newSubState;
        newSubState.SetSuperState(this);
        newSubState.Enter();
    }
    protected void SwitchStates(PlayerState newPlayerState)
    {
        Exit();
        if(superState==null) player.ChangeState(newPlayerState);
        else superState.SetSubState(newPlayerState);
    }
}
