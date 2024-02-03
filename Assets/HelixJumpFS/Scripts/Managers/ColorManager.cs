using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorManager : MonoBehaviour
{
    [SerializeField] private Material ball;

    [Header("Var1")]
    [SerializeField] private Color AxisColor1;
    [SerializeField] private Color DefaultSegmentColor1;
    [SerializeField] private Color TrapSegmentColor1;
    [SerializeField] private Color FinishColor1;

    [SerializeField] private Color GradientTopColor1;
    [SerializeField] private Color GradientDownColor1;

    [Header("Var2")]
    [SerializeField] private Color AxisColor2;
    [SerializeField] private Color DefaultSegmentColor2;
    [SerializeField] private Color TrapSegmentColor2;
    [SerializeField] private Color FinishColor2;

    [SerializeField] private Color GradientTopColor2;
    [SerializeField] private Color GradientDownColor2;

    [Header("Var3")]
    [SerializeField] private Color AxisColor3;
    [SerializeField] private Color DefaultSegmentColor3;
    [SerializeField] private Color TrapSegmentColor3;
    [SerializeField] private Color FinishColor3;

    [SerializeField] private Color GradientTopColor3;
    [SerializeField] private Color GradientDownColor3;

    [Header("Var4")]
    [SerializeField] private Color AxisColor4;
    [SerializeField] private Color DefaultSegmentColor4;
    [SerializeField] private Color TrapSegmentColor4;
    [SerializeField] private Color FinishColor4;

    [SerializeField] private Color GradientTopColor4;
    [SerializeField] private Color GradientDownColor4;

    [Header("Var5")]
    [SerializeField] private Color AxisColor5;
    [SerializeField] private Color DefaultSegmentColor5;
    [SerializeField] private Color TrapSegmentColor5;
    [SerializeField] private Color FinishColor5;

    [SerializeField] private Color GradientTopColor5;
    [SerializeField] private Color GradientDownColor5;

    [SerializeField] private Material Axis;
    [SerializeField] private Material DefaultSegment;
    [SerializeField] private Material TrapSegment;
    [SerializeField] private Material Finish;

    [SerializeField] private Camera GradientTop;
    [SerializeField] private Image GradientDown;

    private void Awake()
    {
        int variation = Random.Range(1, 6);

        if (variation == 1)
        {
            Axis.color = AxisColor1;
            DefaultSegment.color = DefaultSegmentColor1;
            TrapSegment.color = TrapSegmentColor1;
            Finish.color = FinishColor1;

            GradientTop.backgroundColor = GradientTopColor1;
            GradientDown.color = GradientDownColor1;
        }

        if (variation == 2)
        {
            Axis.color = AxisColor2;
            DefaultSegment.color = DefaultSegmentColor2;
            TrapSegment.color = TrapSegmentColor2;
            Finish.color = FinishColor2;

            GradientTop.backgroundColor = GradientTopColor2;
            GradientDown.color = GradientDownColor2;
        }

        if (variation == 3)
        {
            Axis.color = AxisColor3;
            DefaultSegment.color = DefaultSegmentColor3;
            TrapSegment.color = TrapSegmentColor3;
            Finish.color = FinishColor3;

            GradientTop.backgroundColor = GradientTopColor3;
            GradientDown.color = GradientDownColor3;
        }

        if (variation == 4)
        {
            Axis.color = AxisColor4;
            DefaultSegment.color = DefaultSegmentColor4;
            TrapSegment.color = TrapSegmentColor4;
            Finish.color = FinishColor4;

            GradientTop.backgroundColor = GradientTopColor4;
            GradientDown.color = GradientDownColor4;
        }

        if (variation == 5)
        {
            Axis.color = AxisColor5;
            DefaultSegment.color = DefaultSegmentColor5;
            TrapSegment.color = TrapSegmentColor5;
            Finish.color = FinishColor5;

            GradientTop.backgroundColor = GradientTopColor5;
            GradientDown.color = GradientDownColor5;
        }

        ball.color = Finish.color;
    }
}
