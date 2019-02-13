using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public int score = 0;
    public int lives = 3;
    public IntUnityEvent onScoreUpdate = new IntUnityEvent();
    public IntUnityEvent onLiveUpdate = new IntUnityEvent();

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Player.instance.destroyedEnemy.AddListener(AddScore);
        Player.instance.playerHit.AddListener(() => changeLives(--lives));
    }

    // Update is called once per frame
    void AddScore(int newScore)
    {
        score += newScore;
        Debug.Log("Update score invoked");
        onScoreUpdate.Invoke(score);
    }

    void changeLives(int newCount)
    {
        lives = newCount;
        onLiveUpdate.Invoke(lives);
    }
}
