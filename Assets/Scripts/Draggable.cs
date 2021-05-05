using UnityEngine;

public class Draggable : MonoBehaviour
{
    [SerializeField]
    private SlotType type;
    [SerializeField]
    private Vector3 bounds;

    private Camera _camera;
    private float offset;
    private Rigidbody _rb;
    private Vector3 initPos;

    public SlotType Type => type;

    private void Start()
    {
        initPos = transform.position;
        _camera = Camera.main;
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (transform.position.y < bounds.y)
        {
            transform.position = initPos;
        }
    }

    private void OnMouseDown()
    {
        offset = _camera.WorldToScreenPoint(transform.position).z;
        _rb.isKinematic = true;
    }

    private void OnMouseDrag()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = offset;
        transform.position = _camera.ScreenToWorldPoint(mousePos);
    }

    private void OnMouseUp()
    {
        _rb.isKinematic = false;
    }
}
