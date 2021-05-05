using UnityEngine;

public class Slot : MonoBehaviour
{
    [SerializeField]
    private SlotType type;

    private void OnTriggerEnter(Collider other)
    {
        var draggable = other.GetComponent<Draggable>();
        if (draggable && type == draggable.Type)
        {
            draggable.GetComponent<Rigidbody>().isKinematic = true;
            draggable.transform.position = transform.position;
            draggable.transform.rotation = transform.rotation;
            Destroy(draggable);
            GameController.instance.FillSlot();
            Destroy(gameObject);
        }
    }
}

public enum SlotType { Box, Wheel }
