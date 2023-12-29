using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    public float smoothTime = 1f; // Smoothing time for camera movement
    public float zoomSpeed = 5f;
    public float minFOV = 3f;
    public float maxFOV = 8f;
    private float targetFOV;

    public CinemachineVirtualCamera vcam;

    private void Start()
    {
        targetFOV = vcam.m_Lens.OrthographicSize;
    }

    void Update()
    {
        // Calculate zoom
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        targetFOV -= scroll * zoomSpeed;
        targetFOV = Mathf.Clamp(targetFOV, minFOV, maxFOV);

        // Apply zooming using smooth FOV change
        vcam.m_Lens.OrthographicSize = Mathf.Lerp(vcam.m_Lens.OrthographicSize, targetFOV, smoothTime);
    }
}
