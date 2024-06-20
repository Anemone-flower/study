using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    public Transform target; // 플레이어의 Transform을 연결할 변수

    // 카메라와 플레이어 사이의 거리를 조절하는 변수
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
