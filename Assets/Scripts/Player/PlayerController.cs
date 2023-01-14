using UnityEngine;

public class PlayerController 
{
    public PlayerController(PlayerModel _playerModel, PlayerView _playerView)
    {
        PlayerModel = _playerModel;
        PlayerView = _playerView;
        PlayerView.playerController = this;
    }

    public PlayerModel PlayerModel { get; }
    public PlayerView PlayerView { get; }

    public void MoveVertical(Transform transform)
    {
        Vector2 position = transform.position;
        position.y += PlayerModel.VerticalSpeed * Time.deltaTime;
        transform.position = position;
    }

    public void Fire(GameObject bullet, Transform firePoint)
    {
        bullet = PlayerView.bulletpool.GetPooledObject();

        if (bullet != null)
        {
            bullet.transform.position = firePoint.position;
            bullet.SetActive(true);
        }
    }

    public void MoveHorizontal(float horizontal, Transform transform)
    {
        Vector2 position = transform.position;
        position.x += horizontal * PlayerModel.HorizontalSpeed * Time.deltaTime;
        transform.position = position;
    }
}
