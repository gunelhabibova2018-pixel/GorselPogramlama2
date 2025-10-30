using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen; // bitiþ ekraný 
    PickupManager pickups;  // sahnedeki kapsüllerin referansý

    int totalPickups; // sahnede olan kapsül sayýsý
    int score = 0; // score sayacý

    private void Start()
    {
        pickups = FindFirstObjectByType<PickupManager>();
        totalPickups = pickups.amount;
        UpdateScore();
    }

    public void CollectPickup()
    {
        score++;
        UpdateScore();

        if(score >= totalPickups)
        {
            gameOverScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void UpdateScore()
    {
        scoreText.text = "Skor: " + score.ToString();
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
