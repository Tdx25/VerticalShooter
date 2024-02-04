using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Image[] healthImages;
    [SerializeField] private int numSegments = 4;

    private void OnEnable()
    {
        PlayerHealth.healthChanged += OnHealthChanged;
        OnHealthChanged(PlayerHealth.GetHealth());
    }

    private void OnDisable()
    {
        PlayerHealth.healthChanged -= OnHealthChanged;
    }

    private void OnHealthChanged(int health)
    {
        Debug.Log("Health: " + health);
        for (int i = 0; i < healthImages.Length; i++)
        {
            float fillPercentage = Mathf.Clamp01((health - i * numSegments) / (float)numSegments);
            healthImages[i].fillAmount = fillPercentage;
        }
    }
}