using UnityEngine;

namespace UI
{
    public class MenuController : MonoBehaviour
    {
        [Header("Panels")]
        public GameObject mainMenuPanel;   
        public GameObject settingsPanel;   

        public void OpenSettings()
        {
            if (mainMenuPanel != null)
                mainMenuPanel.SetActive(false);

            if (settingsPanel != null)
                settingsPanel.SetActive(true);
        }

        public void BackToMainMenu()
        {
            if (settingsPanel != null)
                settingsPanel.SetActive(false);

            if (mainMenuPanel != null)
                mainMenuPanel.SetActive(true);
        }
    }
}