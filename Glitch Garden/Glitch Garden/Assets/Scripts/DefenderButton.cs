using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] Defender defenderPrefab;

    private void Start()
    {
        LabelButtonWithCost();
    }

    private void LabelButtonWithCost()
    {
        TextMeshProUGUI costText = GetComponentInChildren<TextMeshProUGUI>();
        if (!costText)
        {
            Debug.LogError(name + "Has no cost text, add one");
        }
        else
        {
            costText.text = defenderPrefab.GetStarCost().ToString();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<Image>().color = new Color32(19, 15, 15, 255);
        }
        GetComponent<Image>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }
}
