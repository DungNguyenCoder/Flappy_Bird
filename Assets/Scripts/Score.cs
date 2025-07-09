using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;

    [SerializeField] public TextMeshProUGUI _currentScoreText;
    [SerializeField] public TextMeshProUGUI _bestScoreText;

    private int _score;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        ResetScore();
        _currentScoreText.text = _score.ToString();
        _bestScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateHighScore();
    }

    private void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", _score);
            _bestScoreText.text = _score.ToString();
        }
    }

    public void UpdateScore()
    {
        _score++;
        _currentScoreText.text = _score.ToString();
        UpdateHighScore();
    }

    public void ResetScore()
    {
        _score = 0;
        _currentScoreText.text = "0";
    }

    public int GetScore()
    {
        return _score;
    }
}
