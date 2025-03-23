using UnityEngine;

[ExecuteInEditMode]
public class CameraPivot : MonoBehaviour
{
    [Range(0,360)]
    public float angle;
    float lastAngle;

    void Start()
    {
        angle = 0;
        lastAngle = 0;
    }

    void Update()
    {
        transform.Rotate(Vector3.down, angle - lastAngle);
        lastAngle = angle;
    }

}
