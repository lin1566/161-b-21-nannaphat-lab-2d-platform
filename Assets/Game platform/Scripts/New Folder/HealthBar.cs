using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image fillImage;
    private Character character;

    public void Setup(Character target)
    {
        character = target;
    }

    void Update()
    {
        if (character == null) return;

        float fill = (float)character.Health / 100f; // ถ้าค่าสูงสุด 100
        fillImage.fillAmount = fill;

        // ให้ HP Bar ตามตัวละคร
        transform.position = Camera.main.WorldToScreenPoint(character.transform.position + Vector3.up * 1.2f);
    }
}
