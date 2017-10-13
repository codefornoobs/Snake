using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    private static int _score = 0;

    // Use this for initialization
    void Awake()
    {


    }

    public static void updateScore(int scoreToUpdate)
    {
        _score += scoreToUpdate;
        if (_score < 0)
            _score = 0;
        Text _scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        _scoreText.text = "Score: " + _score;
    }
}
