using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool hasStarted = false;
    public bool hasIntro = false;

    [SerializeField] GameObject _gameOverCanvas;
    [SerializeField] GameObject _startGameCanvas;
    [SerializeField] GameObject _scoreGameCanvas;
    [SerializeField] GameObject _introGameCanvas;
    [SerializeField] GameObject _introBird;
    [SerializeField] GameObject _bird;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        Time.timeScale = 1f;
    }

    void Update()
    {
        if (!hasStarted && hasIntro && Mouse.current.leftButton.wasPressedThisFrame)
        {
            hasStarted = true;
            Debug.Log("Game started");
            _bird.SetActive(true);
            _startGameCanvas.SetActive(false);
            _scoreGameCanvas.SetActive(true);
        }
    }

    public void GameOver()
    {
        _gameOverCanvas.SetActive(true);
        _scoreGameCanvas.SetActive(false);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Debug.Log("Restart game");
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        _gameOverCanvas.SetActive(false);
        _scoreGameCanvas.SetActive(true);
    }

    public void StartGame()
    {
        Debug.Log("Start game");
        Time.timeScale = 1f;
        hasIntro = true;
        _introBird.SetActive(false);
        _introGameCanvas.SetActive(false);
        _startGameCanvas.SetActive(true);
    }
}
