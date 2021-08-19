using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class ButtonSceneManager : MonoBehaviour
    {
        public void ToPvEScene()
        {
            SceneManager.LoadScene("PlayerVsPC");
        }

        public void ToPvPScene()
        {
            SceneManager.LoadScene("PlayerVsPlayer");
        }

        public void ToMainMenuScene()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}