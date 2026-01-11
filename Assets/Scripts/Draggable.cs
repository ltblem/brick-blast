using System;
using UnityEngine;

public class Draggable: MonoBehaviour
{
    private Vector3 offset;
    private Camera cam;

    void Awake()
    {
        cam = Camera.main;
    }

    void OnMouseDown()
    {
        Vector3 mouseWorldPos = cam.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0f;
        offset = transform.position - mouseWorldPos;
    }

    private void OnMouseDrag()
    {
        Vector3 mouseWorldPos = cam.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0f;
        transform.position = mouseWorldPos + offset;
    }
}