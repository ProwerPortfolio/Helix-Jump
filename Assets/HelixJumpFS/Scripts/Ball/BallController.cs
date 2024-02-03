using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BallMovement))]
public class BallController : OneColliderTrigger
{
    [SerializeField] private BallTrail ballTrail;

    private Floor floor;

    private BallMovement movement;

    [HideInInspector] public UnityEvent<SegmentType> CollisionSegment;

    private void Start()
    {
        movement = GetComponent<BallMovement>();
    }

    protected override void OnOneTriggerEnter(Collider other)
    {
        Segment segment = other.GetComponent<Segment>();

        if (segment != null)
        {
            if (segment.Type == SegmentType.Empty)
            {
                movement.Fall(other.transform.position.y);
            }

            if (segment.Type == SegmentType.Default)
            {
                movement.Jump();
            }

            if (segment.Type == SegmentType.Trap || segment.Type == SegmentType.Finish)
            {
                movement.Stop();
            }

            CollisionSegment.Invoke(segment.Type);

            floor = other.gameObject.GetComponentInParent<Floor>();
            segment = other.gameObject.GetComponent<Segment>();

            if (segment.Type == SegmentType.Empty && segment != null)
            {
                floor.DestructSegments();
            }
            else
            {
                ballTrail.parentTransform = segment.GetComponent<Transform>();
                ballTrail.SpawnBlot();
            }
        }
    }

    protected override void OnOneTriggerExit(Collider other)
    {
        Segment segments = other.GetComponent<Segment>();

        
    }
}
