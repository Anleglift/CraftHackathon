using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollCamera : MonoBehaviour
{
    public float scrollSpeed = 1f;
    public Vector3 startPosition;
    public Vector3 CanvasPosition;
    public Vector3 endPosition;
    private void Update()
    {
        CanvasPosition = transform.position;
        if (CanvasPosition.y <= startPosition.y)
        {
            transform.position = startPosition;
        }
        if (CanvasPosition.y >= endPosition.y)
        {
            transform.position = endPosition;
        }
        // Get the scroll wheel input
        float scrollInput = Input.mouseScrollDelta.y;

        // Move the camera downwards based on the scroll input
        Vector3 newPosition = transform.position + Vector3.down * scrollInput * scrollSpeed;
        transform.position = newPosition;
    }
}
