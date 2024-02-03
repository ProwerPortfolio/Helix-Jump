using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UILevelProgress : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;

    [SerializeField] private LevelGenerator levelGenerator;

    [SerializeField] private TextMeshProUGUI currentLevelText;
    [SerializeField] private TextMeshProUGUI nextLevelText;

    [SerializeField] private Image progressBar;

    private void Start()
    {
        currentLevelText.text = levelProgress.CurrentLevel.ToString();
        nextLevelText.text = (levelProgress.CurrentLevel + 1).ToString();

        progressBar.fillAmount = 0;
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty || type == SegmentType.Finish)
        {
            progressBar.fillAmount += 1 / levelGenerator.FloorAmount;
        }
    }
}
