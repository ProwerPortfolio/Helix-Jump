using UnityEngine;

public class BallTrail : BallEvents
{
    [HideInInspector] public Transform parentTransform;
    [SerializeField] private Transform visualModel;
    [SerializeField] private GameObject blotPrefab;
    [SerializeField] private float offset;

    public void SpawnBlot()
    {
        GameObject blot = Instantiate(blotPrefab, parentTransform);

        blot.transform.position = new Vector3(visualModel.position.x, transform.position.y + offset, visualModel.position.z);
        blot.transform.eulerAngles = new Vector3(90, Random.Range(0, 360), 0);
        blot.GetComponent<SpriteRenderer>().color = visualModel.GetComponent<MeshRenderer>().material.color;
    }
}
