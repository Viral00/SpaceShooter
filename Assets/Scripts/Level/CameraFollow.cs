using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private float verticalSpeed = 5f;

    private void MoveUp()
    {
        Vector2 position = transform.position;
        position.y += verticalSpeed * Time.deltaTime;
        transform.position = position;
    }

    private void Update()
    {
        MoveUp();
    }
}

/*public Transform player;
   public Vector3 offset;
   private float damping;

   private Vector2 velocity = Vector2.zero;

   private void FixedUpdate()
   {
       Vector2 movePosition = player.position + offset;
       transform.position = Vector2.SmoothDamp(transform.position, movePosition, ref velocity, damping);
   }*/