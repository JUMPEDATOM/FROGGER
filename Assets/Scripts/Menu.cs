using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    void playGame()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      Score.currentScore = 0;
    }
}
