using UnityEngine.Localization.Settings;
using UnityEngine;

public class LanguageSelector : MonoBehaviour
{
    public void SetEnglish() //cambia el idioma seleccionado a inglés
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.GetLocale("en");
    }

    public void SetSpanish() //cambia el idioma seleccionado a español
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.GetLocale("es");
    }
}
