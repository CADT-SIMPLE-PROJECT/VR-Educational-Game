using UnityEngine;
using UnityEngine.UI;

public class LanguageText : MonoBehaviour
{
    public string key;
    private Text text;

    void Start()
    {
        text = GetComponent<Text>();
        UpdateText();
    }

    public void UpdateText()
    {
        text.text = LanguageManager.instance.GetText(key);
        text.font = LanguageManager.instance.GetFont();
    }
}