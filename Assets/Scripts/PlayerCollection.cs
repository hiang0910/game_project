using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
    private GameManeger gameManager;
    private void Awake()
    {
        gameManager = FindObjectOfType<GameManeger>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("coin"))
        {
            gameManager.AddScore(1);
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Trop"))
        {
            gameManager.GameOver();

        }
        else if (collision.CompareTag("Enemy"))
        {
            gameManager.GameOver();

        }
        else if (collision.CompareTag("Key"))
        {
            Destroy(collision.gameObject);
            gameManager.GameWin();
        }
    }
}