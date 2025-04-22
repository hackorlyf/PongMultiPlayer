using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Scenes : MonoBehaviour
{
    // Define your enum for scenes
    [Serializable]
    public enum SceneNames
    {
        MAIN_MENU,
        SINGLE_PLAYER,
        MULTIPLAYER
    }

    // Start is called before the first frame update
    void Start()
    {
        GameEvents.OnPlayBtnClicked += LoadScene;
    }

    void OnDestroy(){
        GameEvents.OnPlayBtnClicked -= LoadScene;
    }

    // Load the scene based on the enum value
    private void LoadScene(SceneNames scene)
    {
        // Get the scene name from the enum
        string sceneName = GetSceneName(scene);
        // Load the scene by name using Unity's SceneManager
        SceneManager.LoadSceneAsync(sceneName);
    }

    // Map enum to scene name (for example purposes)
    private string GetSceneName(SceneNames scene)
    {
        switch (scene)
        {
            case SceneNames.MAIN_MENU:
                return "MainMenu"; // Ensure this matches the scene's actual name in the Build Settings
            case SceneNames.SINGLE_PLAYER:
                return "Singleplayer";
            case SceneNames.MULTIPLAYER:
                return "Multiplayer";
            default:
                return null;
        }
    }
}
