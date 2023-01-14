using UnityEngine;

public class PlayerModel
{
    public PlayerModel(float horizontalSpeed, float speed)
    {
        HorizontalSpeed = horizontalSpeed;
        VerticalSpeed = speed;
    }
    public float HorizontalSpeed { get; }
    public float VerticalSpeed { get; }
}
