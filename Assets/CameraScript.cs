using UnityEngine;
using Cinemachine;

public class CameraScript : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;
    public float rotationSpeed = 5f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Vertical");
        float verticalInput = Input.GetAxis("Horizontal");

        if (virtualCamera != null)
        {
            // カメラの回転を更新
            CinemachineComposer composer = virtualCamera.GetCinemachineComponent<CinemachineComposer>();
            if (composer != null)
            {
                composer.m_TrackedObjectOffset.x += horizontalInput * rotationSpeed * Time.deltaTime;
                composer.m_TrackedObjectOffset.y += verticalInput * rotationSpeed * Time.deltaTime;
            }
        }
    }
}