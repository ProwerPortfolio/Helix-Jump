using UnityEngine;
using TMPro;

public class UIScoreText : BallEvents
{
    [SerializeField] private ScoresCollector scoresCollector;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI hightScoreText;
    public TextMeshProUGUI emptyMultiplicatorText;

    public float timer;

    public Animator animator;

    private void Start()
    {
        animator = emptyMultiplicatorText.GetComponent<Animator>();

        UpdateText();
    }

    public void UpdateText()
    {
        scoreText.text = scoresCollector.Scores.ToString();
        hightScoreText.text = scoresCollector.hightScore.ToString();
        if (scoresCollector.scoreMuliplicator > 1) emptyMultiplicatorText.text = scoresCollector.scoreMuliplicator.ToString();
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty || type == SegmentType.Finish)
        {
            UpdateText();
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer < 0.5)
        {
            emptyMultiplicatorText.gameObject.SetActive(true);
            animator.enabled = true;
        }

        if (timer >= 0.5)
        {
            animator.enabled = false;
            emptyMultiplicatorText.gameObject.SetActive(false);
        }
    }
}
