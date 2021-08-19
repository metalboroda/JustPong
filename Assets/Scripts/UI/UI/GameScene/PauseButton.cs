using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI.UI.GameScene
{
    public class PauseButton : MonoBehaviour
    {
        public Button pauseButton;
        private Image buttonSprite;
        public GameObject pausePanel;
        private bool isPaused;

        private void Awake()
        {
            buttonSprite = GetComponent<Image>();
        }

        private void Start()
        {
            isPaused = true;
            Time.timeScale = 0;
        }

        public void PauseEnable()
        {
            if (isPaused)
            {
                buttonSprite.enabled = true;
                pauseButton.enabled = true;
                pausePanel.SetActive(false);
                Time.timeScale = 1;
                isPaused = false;
            }
            else if (!isPaused)
            {
                buttonSprite.enabled = false;
                pauseButton.enabled = false;
                pausePanel.SetActive(true);
                Time.timeScale = 0;
                isPaused = true;
            }
        }

        private void OnDisable()
        {
            // Time.timeScale = 1;
        }
    }
}