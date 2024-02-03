using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotator : MonoBehaviour
{
    [SerializeField] private string mouseInputAxis;
    [SerializeField] private float senvitive;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0, Input.GetAxis(mouseInputAxis) * -senvitive, 0);
        }
    }
}
