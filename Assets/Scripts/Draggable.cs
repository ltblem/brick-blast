using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    private Vector3 offset;
    private Camera cam;

    void Awake()
    {
        cam = Camera.main;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Vector3 worldPos = cam.ScreenToWorldPoint(eventData.position);
        worldPos.z = 0f;
        offset = transform.position - worldPos;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 worldPos = cam.ScreenToWorldPoint(eventData.position);
        worldPos.z = 0f;
        transform.position = worldPos + offset;
    }
}