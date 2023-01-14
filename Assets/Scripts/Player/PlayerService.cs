using UnityEngine;

public class PlayerService : MonoSingleton<PlayerService>
{
    public PlayerView playerPrefab;

    public void Start()
    {
        Time.timeScale = 1f;
        PlayerModel playerModel = new PlayerModel(15f, 5f);
        PlayerController playerController = new PlayerController(playerModel, playerPrefab);
    }
}
