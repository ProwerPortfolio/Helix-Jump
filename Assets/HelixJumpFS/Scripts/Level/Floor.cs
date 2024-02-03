using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField] private List<Segment> defaultSegments;

    [SerializeField] private List<Segment> segments;

    public void AddEmptySegment(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            defaultSegments[i].SetEmpty();
        }

        for (int i = amount; i >= 0; i--)
        {
            defaultSegments.RemoveAt(i);
        }
    }

    public void AddRandomTrapSegment(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            int index = Random.Range(0, defaultSegments.Count);

            defaultSegments[index].SetTrap();
            defaultSegments.RemoveAt(index);
        }
    }

    public void SetRandomRotation()
    {
        transform.eulerAngles = new Vector3(0, Random.Range(0, 360), 0);
    }

    public void SetFinishAllSegment()
    {
        for (int i = 0; i < defaultSegments.Count; i++)
        {
            defaultSegments[i].SetFinish();
        }
    }

    public void DestructSegments()
    {
        for (int i = 0; i < segments.Count; i++)
        {
            if (segments[i].Type != SegmentType.Empty)
            {
                Collider collider = segments[i].GetComponent<Collider>();
                collider.isTrigger = false;
                collider.enabled = false;
                Rigidbody rigidbody = segments[i].GetComponent<Rigidbody>();
                rigidbody.isKinematic = false;
                Animator animator = segments[i].GetComponent<Animator>();
                animator.enabled = true;
            }
        }
    }
}
