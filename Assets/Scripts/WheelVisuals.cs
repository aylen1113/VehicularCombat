using UnityEngine;

public class WheelVisuals : MonoBehaviour
{
    public WheelCollider wheelCollider;
    public Transform wheelTransform;

    void Update()
    {
        UpdateWheelVisuals();
    }

    void UpdateWheelVisuals()
    {
        Vector3 position;
        Quaternion rotation;
        wheelCollider.GetWorldPose(out position, out rotation);

        wheelTransform.position = position;
        wheelTransform.rotation = rotation;
    }
}
