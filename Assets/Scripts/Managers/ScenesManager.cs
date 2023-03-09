using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager
{
    public void LoadScene(string sceneName)
    {
        Scene sceneToBeLoaded = SceneManager.GetSceneByName(sceneName);
        if (sceneToBeLoaded.buildIndex != -1)
            SceneManager.LoadScene(sceneName);
        else
            Debug.LogError("Failed to load scene: " + sceneName +
                "\nProbably scene is not loaded.");
    }
}
