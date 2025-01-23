using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Untuk memuat scene

public class Timer : MonoBehaviour
{
    float currentTime;
    public float startingTime = 10f;

    [SerializeField] Text countdownText;
    [SerializeField] GameObject gameOverPanel; // Panel Game Over
    [SerializeField] Button home; // Tombol Home

    void Start()
    {
        currentTime = startingTime;

        // Pastikan panel Game Over tersembunyi saat game dimulai
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            countdownText.text = currentTime.ToString("F2"); // Format ke 2 angka desimal
        }
        else
        {
            currentTime = 0;
            countdownText.text = "Time's up!";
            GameOver(); // Panggil fungsi Game Over
        }
    }

    void GameOver()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true); // Menampilkan panel Game Over
        }

        // Hentikan semua aktivitas game, misalnya:
        Time.timeScale = 0f; // Menghentikan waktu dalam game
    }

    public void NamaScene(string scenename)
    {
        SceneManager.LoadScene("main menu");
    }
}