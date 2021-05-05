using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject panel;
    
    public void ShowPanel()
    {
        panel.SetActive(true);
    }
}
