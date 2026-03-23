using UnityEngine;

namespace UI
{
    public class MenuController : MonoBehaviour
    {
        [Header("Panels")]
        public GameObject mainMenuPanel;
        public GameObject settingsPanel;
        public GameObject openingTextPanel;

        [Header("Locomotion Objects")]
        public GameObject locomotionSystem;

        void Start()
        {
            // Disable movement at start
            if (locomotionSystem != null) locomotionSystem.SetActive(false);

            // Show correct panels
            if (mainMenuPanel != null) mainMenuPanel.SetActive(true);
            if (openingTextPanel != null) openingTextPanel.SetActive(false);
        }

        public void StartGame()
        {
            if (mainMenuPanel != null) mainMenuPanel.SetActive(false);
            if (openingTextPanel != null) openingTextPanel.SetActive(true);
        }

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

        public void SkipIntro()
        {
            if (openingTextPanel != null) openingTextPanel.SetActive(false);

            // Enable movement
            if (locomotionSystem != null) locomotionSystem.SetActive(true);

            // Hide UI (optional)
            gameObject.SetActive(false);
        }
    }
}