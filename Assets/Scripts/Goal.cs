using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
      Score.currentScore += 100;
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
