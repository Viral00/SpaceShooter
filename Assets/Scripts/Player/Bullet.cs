using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float bulletforce = 2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
            ScoreController.Instance.IncreaseScore(10);
            EnemyController.Instance.DamageToEnemy(10);
        }
        else if (collision.gameObject.CompareTag("End"))
        {
            gameObject.SetActive(false);
        }
    }
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (gameObject.activeInHierarchy)
        {
            rb.AddForce(transform.up * bulletforce, ForceMode2D.Impulse);
        }     
    }
}
