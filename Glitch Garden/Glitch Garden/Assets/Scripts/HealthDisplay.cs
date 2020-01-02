using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] int defaultHealth = 11;
    int health;
    TextMeshProUGUI healthText;
    [SerializeField]int damage;

    void Start()
    {
        health = ((int)defaultHealth - PlayerPrefsController.GetDifficulty());
        healthText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        healthText.text = health.ToString();
    }

    public void RemoveHealth()
    {
        health -= damage;
        UpdateDisplay();
        if (health <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}
