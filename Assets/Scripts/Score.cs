using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float currentScore = 0f;
    public Text scoreText;

    void Start()
    {
      scoreText.text = currentScore.ToString();
    }
}
