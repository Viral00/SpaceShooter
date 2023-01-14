using TMPro;
using UnityEngine;

public class PlayerHealth : MonoSingleton<PlayerHealth>
{
    private int health = 100;
    public TextMeshProUGUI playerHealth;

    private void Start()
    {
        RefreshUI();
    }

    public void DamageToPlayer(int decrerement)
    {
        health -= decrerement;
        RefreshUI();
    }

    private void Update()
    {
        if(health == 0)
        {
            GameOverUI.Instance.GameOver();
        }
    }
    private void RefreshUI()
    {
        playerHealth.text = "Player Health : " + health;
    }
}
