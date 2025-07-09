using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _finalScore;
    [SerializeField] TextMeshProUGUI _bestScore;

    void Start()
    {
        _finalScore.text = Score.instance.GetScore().ToString();
        _bestScore.text = Score.instance._bestScoreText.text;
    }
}
