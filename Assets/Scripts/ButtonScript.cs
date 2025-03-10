using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private TMP_Text text;
    
    public void SetText(string buttonText) => text.text = buttonText;

    public Button GetButton()
    {
        return button;
    }

    // когда лень в инспекторе прокидывать
    private void OnValidate()
    {
        if (button == null) button = GetComponent<Button>();
        if (text == null) text = GetComponentInChildren<TMP_Text>();
    }
}
