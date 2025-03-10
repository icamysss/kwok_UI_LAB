using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private TMP_Text text;
    [SerializeField] private Image star1, star2, star3;
    


    private void Start()
    {
        button.onClick.AddListener(AddStars);
    }

    public void SetText(string buttonText) => text.text = buttonText;

    public Button GetButton()
    {
        return button;
    }
    
    public int Stars
    {
        get
        {
            var s = 0;
            if (star1.IsActive()) s += 1;
            if (star2.IsActive()) s += 1;
            if (star3.IsActive()) s += 1;
            return s;
        }

        set
        {
            value = Mathf.Clamp(value, 0, 3);

            switch (value)
            {
                case 0:
                    star1.enabled = false;
                    star2.enabled = false;
                    star3.enabled = false;
                    break;
                case 1:
                    star1.enabled = true;
                    star2.enabled = false;
                    star3.enabled = false;
                    break;
                case 2:
                    star1.enabled = true;
                    star2.enabled = true;
                    star3.enabled = false;
                    break;
                case 3:
                    star1.enabled = true;
                    star2.enabled = true;
                    star3.enabled = true;
                    break;
                default:
                    throw new Exception("Invalid stars");
            }
        }
    }
    // когда лень в инспекторе прокидывать
    private void OnValidate()
    {
        if (button == null) button = GetComponent<Button>();
        if (text == null) text = GetComponentInChildren<TMP_Text>();
    }

    private void AddStars()
    {
        if (Stars == 3) Stars = 0;
        else
        {
            Stars++;
        }
    }
}
