using TMPro;
using UnityEngine;

public class EnemyController : MonoSingleton<EnemyController>
{
    [SerializeField] private float dirX1;
    [SerializeField] private float dirX2;
    [SerializeField] private bool moveRight;
    [SerializeField] [Range(0, 10)] private float moveSpeed;
    private float verticalSpeed = 5f;
    private int health = 700;
    [SerializeField] private TextMeshProUGUI enemyHealth;

    private void Start()
    {
        RefreshUI();
    }

    private void Update()
    {
        if (health <= 0)
        {
            GameOverUI.Instance.GameOver();
        }
    }
    private void FixedUpdate()
    {
        MoveUp();
        HorizontalMove();
    }

    private void HorizontalMove()
    {
        if (transform.position.x > dirX2)
            moveRight = false;
        else if (transform.position.x < dirX1)
            moveRight = true;

        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
        }
    }

    private void MoveUp()
    {
        Vector2 position = transform.position;
        position.y += verticalSpeed * Time.deltaTime;
        transform.position = position;
    }

    public void DamageToEnemy(int decrerement)
    {
        health -= decrerement;
        RefreshUI();
    }

    private void RefreshUI()
    {
        enemyHealth.text = "Enemy Health : " + health;
    }
}
