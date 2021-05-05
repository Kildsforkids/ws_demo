using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    [SerializeField]
    private UIController uiController;
    [SerializeField]
    private List<Slot> slots;
    [SerializeField]
    private int remain;

    private void Start()
    {
        if (instance) Destroy(this);
        instance = this;

        Application.targetFrameRate = 60;
        slots = new List<Slot>(FindObjectsOfType<Slot>());
        remain = slots.Count;
    }

    public void FillSlot()
    {
        remain--;
        if (remain <= 0)
        {
            uiController.ShowPanel();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
