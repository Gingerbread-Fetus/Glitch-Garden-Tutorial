using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] Defender defenderPrefab;

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
