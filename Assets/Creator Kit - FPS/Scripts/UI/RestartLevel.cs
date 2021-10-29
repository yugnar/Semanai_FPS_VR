using UnityEngine;
using UnityEngine.SceneManagement;

namespace Photon.Pun.Demo.Asteroids
{
    public class RestartLevel : MonoBehaviour
    {
        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void NextLevel()
        {
            UIAudioPlayer.PlayPositive();
            GameSystem.Instance.NextLevel();
        }
    }
}
