using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace UI
{
    public class AudioVolumeController : MonoBehaviour
    {
        public Button soundtrackButton;
        private bool _isSoundtrackPlay;
        public AudioMixerGroup soundtrack;

        private void Start()
        {
            soundtrackButton.image.color = Color.white;
        }

        public void SoundtrackEnableSwitch()
        {
            if (!_isSoundtrackPlay)
            {
                _isSoundtrackPlay = false;
                soundtrackButton.image.color = new Color(1f, 1f, 1f, 0.39f);
                soundtrack.audioMixer.SetFloat("Soundtrack", -80.0f);
            }
            else if (_isSoundtrackPlay)
            {
                _isSoundtrackPlay = true;
                soundtrackButton.image.color = Color.white;
                soundtrack.audioMixer.SetFloat("Soundtrack", -0.0f);
            }
        }
    }
}