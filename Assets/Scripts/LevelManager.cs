using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public int score = 0;
    public IntUnityEvent onScoreUpdate = new IntUnityEvent();

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Enemy.instance.destroyedEnemy.AddListener(() => UpdateScore(++score));
    }

    // Update is called once per frame
    void UpdateScore(int newScore)
    {
        score = newScore;
        onScoreUpdate.Invoke(newScore);
    }
}
