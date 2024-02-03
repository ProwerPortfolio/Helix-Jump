using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoresCollector : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;

    [SerializeField] private UIScoreText scoreText;

    [HideInInspector] public int scores;
    [HideInInspector] public int hightScore;

    [HideInInspector] public int scoreMuliplicator = 1;

    private bool isFirst = true;
    private bool isDouble = false;

    public int Scores => scores;

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty)
        {
            if (isDouble == true)
            {
                scoreText.emptyMultiplicatorText.gameObject.SetActive(false);
                scoreText.animator.enabled = false;

                scoreMuliplicator++;
                scoreText.timer = 0;
            }

            if (isFirst == true)
            {
                isFirst = false;
                isDouble = true;
            }

            scores += levelProgress.CurrentLevel * scoreMuliplicator;
            if (hightScore < scores) hightScore = scores;
            PlayerPrefs.SetInt("ScoresCollector:hightScores", hightScore);

            
        }
        else
        {
            isFirst = true;
            isDouble = false;
            scoreMuliplicator = 1;
        }

        scoreText.UpdateText();
    }
}
