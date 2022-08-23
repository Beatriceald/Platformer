using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeIcon : MonoBehaviour
{
    public Image Backgound;
    public Image Foreground;
    public Text Text;

    public void StartCharge()
    {
        Backgound.color = new Color(1f, 1f, 1f, 0.2f);
        Foreground.enabled = true;
        Text.enabled = true;
    }

    public void StopCharge()
    {
        Backgound.color = new Color(1f, 1f, 1f, 1f);
        Foreground.enabled = false;
        Text.enabled = false;
    }

    public void SetChargeValue(float currentCharge, float MaxCharge)
    {
        Foreground.fillAmount = currentCharge / MaxCharge;
        Text.text = Mathf.Ceil(MaxCharge - currentCharge).ToString();
    }
}
