using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIDisplay : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] Slider healthSlider;
    [SerializeField] Health PlayerHealth;

    [Header("Score")]
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    void Start()
    {
        healthSlider.maxValue = PlayerHealth.GetHealth();
    }

    void Update()
    {
        healthSlider.value = PlayerHealth.GetHealth();
        scoreText.text = scoreKeeper.GetScore().ToString("000000000");
    }
}
