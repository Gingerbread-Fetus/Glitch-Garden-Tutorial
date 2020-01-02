using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] int health = 5;
    TextMeshProUGUI healthText;
    [SerializeField]int damage;

    void Start()
    {
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
