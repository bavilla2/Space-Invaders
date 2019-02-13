using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = this.GetComponent<TextMeshProUGUI>();
        LevelManager.instance.onScoreUpdate.AddListener(UpdateScore);
    }

    // Update is called once per frame
    void UpdateScore(int newScore)
    {
        scoreText.text = string.Format("Score: {0}", newScore);
    }
}
