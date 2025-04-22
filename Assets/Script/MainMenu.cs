using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button PlayBtn;
    [SerializeField] private Button MultiplayerBtn;
    [SerializeField] private Button QuitBtn;

    void Start()
    {
        if (PlayBtn != null)
        {
            // Correct way to add a listener using a lambda expression
            PlayBtn.onClick.AddListener(() => {
                GameEvents.InvokeOnPlayBtnClicked();
            });
        }
        if (MultiplayerBtn != null)
        {
            // Correct way to add a listener using a lambda expression
            MultiplayerBtn.onClick.AddListener(() => {
                GameEvents.InvokeOnMultiplayerBtnClicked();
            });
        }
        if (QuitBtn != null)
        {
            // Correct way to add a listener using a lambda expression
            QuitBtn.onClick.AddListener(() => {
                Application.Quit();
            });
        }
    }

    void OnDestroy()
    {
        if (PlayBtn != null)
        {
            // Correct way to add a listener using a lambda expression
            PlayBtn.onClick.RemoveAllListeners();
        }
    }
}
