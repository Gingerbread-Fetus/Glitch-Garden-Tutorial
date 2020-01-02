using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int defaultStarCost = 100;

    public void AddStars(int amount)
    {
        FindObjectOfType<StarDisplay>().AddStars(amount);
    }

    public int GetStarCost()
    {
        //On highest difficulty, prices should be doubled.
        return defaultStarCost * (1 + PlayerPrefsController.GetDifficulty() / 10);
    }
}
