using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    #region Delegates

    public delegate void SceneEvent(Scenes.SceneNames sceneName);
    public delegate void PopupEvent();

    #endregion

    #region Events

    public static event SceneEvent OnPlayBtnClicked;
    public static event PopupEvent OnMultiplayerBtnClicked;

    #endregion

    #region Invokation

    public static void InvokeOnPlayBtnClicked() {
        OnPlayBtnClicked?.Invoke(Scenes.SceneNames.SINGLE_PLAYER);
    }

    public static void InvokeOnMultiplayerBtnClicked() {
        OnMultiplayerBtnClicked?.Invoke();
    }

    #endregion
}
