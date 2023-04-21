using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour
{

    public Transform target;        // The target object to follow
    public Vector3 offset;         // The offset from the target
    public float smoothTime = 0.3f; // Smoothing time for camera movement

    private Vector3 velocity;      // Velocity for smooth dampening

    void LateUpdate()
    {
        // Calculate the target position with offset
        Vector3 targetPosition = target.position + offset;

        // Smoothly move the camera towards the target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}


