using System.Collections;
using TMPro;
using UnityEngine;

public class DelayedText : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public float delay = 0.1f;
    private string fullText;
    private string currentText = "You Are Late, You're Fired";

    void Start()
    {
        fullText = textComponent.text;
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i <= fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            textComponent.text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }
}