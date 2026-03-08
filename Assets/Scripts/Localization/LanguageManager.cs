using UnityEngine;
using System.Collections.Generic;

public class LanguageManager : MonoBehaviour
{
    public static LanguageManager instance;

    public enum Language
    {
        English,
        Khmer
    }

    public Language currentLanguage;

    public Font englishFont;
    public Font khmerFont;

    Dictionary<string, string> translations;

    void Awake()
    {
        instance = this;

        int saved = PlayerPrefs.GetInt("language", 0);
        currentLanguage = (Language)saved;

        LoadLanguage();
    }

    public void SetLanguage(int index)
    {
        currentLanguage = (Language)index;

        PlayerPrefs.SetInt("language", index);

        LoadLanguage();

        LanguageText[] texts = FindObjectsOfType<LanguageText>();

        foreach (LanguageText t in texts)
        {
            t.UpdateText();
        }
    }

    void LoadLanguage()
    {
        string fileName = currentLanguage == Language.English ? "en" : "km";

        TextAsset jsonFile = Resources.Load<TextAsset>("Localization/" + fileName);

        translations = JsonUtility.FromJson<LocalizationData>(jsonFile.text).ToDictionary();
    }

    public string GetText(string key)
    {
        return translations.ContainsKey(key) ? translations[key] : key;
    }

    public Font GetFont()
    {
        return currentLanguage == Language.English ? englishFont : khmerFont;
    }
}