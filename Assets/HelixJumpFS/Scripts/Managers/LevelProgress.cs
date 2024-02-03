using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelProgress : BallEvents
{
    [SerializeField] private ScoresCollector scoresCollector;

    private int currentLevel = 1;
    public int CurrentLevel => currentLevel;

    protected override void Awake()
    {
        base.Awake();

        Load();
    }

#if UNITY_EDITOR
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            Reset();
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
#endif

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Finish)
        {
            currentLevel++;
            Save();
        }
    }

    private void Save()
    {
        PlayerPrefs.SetInt("LevelProgress:currentLevel", currentLevel);
        PlayerPrefs.SetInt("ScoresCollector:scores", scoresCollector.scores);
        PlayerPrefs.SetInt("ScoresCollector:hightScores", scoresCollector.hightScore);
    }

    private void Load()
    {
        currentLevel = PlayerPrefs.GetInt("LevelProgress:currentLevel", 1);
        scoresCollector.scores = PlayerPrefs.GetInt("ScoresCollector:scores", 0);
        scoresCollector.hightScore = PlayerPrefs.GetInt("ScoresCollector:hightScores", 0);
    }

#if UNITY_EDITOR
    private void Reset()
    {
        PlayerPrefs.DeleteAll();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
#endif
}
