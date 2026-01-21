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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space is pressed");
            player.HandleInput(PlayerCommand.Start);
        }
    }
}
