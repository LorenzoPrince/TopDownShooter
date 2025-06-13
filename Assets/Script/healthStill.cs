using UnityEngine;
using UnityEngine.UI;
public class healthStill : MonoBehaviour
{
    public Image healthbar;
    public float currentHealth;
    public float maxHealth;
    void Start()
    {
        UpdateStill();
    }

    public void UpdateStill()
    {
        healthbar.fillAmount = currentHealth / maxHealth;
    }
}