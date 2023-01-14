using System.Collections;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public PlayerController playerController;
    public Bullet bullet;
    public Transform firePoint;
    public BulletPool bulletpool;
    public LevelSpawn levelSpawn;
    private Rigidbody2D rb;
    private float horizontal;

    public PlayerView(PlayerController playerController)
    {
        PlayerController = playerController;
    }

    public PlayerController PlayerController { get; }

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Fire()
    {
        playerController.Fire(bullet.gameObject, firePoint);
    }

    private void Update()
    {
        InvokeRepeating("Fire", 2.0f, 2f);
    }

    private void FixedUpdate()
    {
        playerController.MoveVertical(transform);
        horizontal = Input.GetAxisRaw("Horizontal");
        playerController.MoveHorizontal(horizontal, transform);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "LevelMove")
        {
            levelSpawn.MoveLevel();
        }
    }
}
