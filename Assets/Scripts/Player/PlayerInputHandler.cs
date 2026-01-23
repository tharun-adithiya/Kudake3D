using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    PlayerController player;
    private void Awake()
    {
        player = GetComponent<PlayerController>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Debug.Log("Enter is pressed");
            player.HandleInput(PlayerCommand.Start);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.HandleInput(PlayerCommand.Jump);
        }
    }
}
