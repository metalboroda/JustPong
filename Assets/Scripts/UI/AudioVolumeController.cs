using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace UI
{
    public class AudioVolumeController : MonoBehaviour
    {
        public static AudioVolumeController Instance = null;

        public Button soundtrackButton;
        public bool isSoundtrackPlay = true;
        public AudioMixerGroup soundtrack;

        public void ToggleMusicMethod()
        {
            if (PlayerPrefs.GetInt("Muted", 0) == 0)
            {
                PlayerPrefs.SetInt("Muted", 1);
                // soundtrackButton.image.color = new Color(1f, 1f, 1f, 0.39f);
                soundtrackButton.image.color = Color.gray;
                soundtrack.audioMixer.SetFloat("Soundtrack", -80.0f);
            }
            else
            {
                PlayerPrefs.SetInt("Muted", 0);
                soundtrackButton.image.color = Color.white;
                soundtrack.audioMixer.SetFloat("Soundtrack", -0.0f);
            }
        }
    }
}