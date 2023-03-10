using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager
{
    /// <summary>
    /// Tries to load a scene by its buildIndex (number at Build Settings):<br/>
    /// 0 - Main Menu<br/>
    /// 1 - Game Scene<br/>
    /// </summary>
    /// <param name="buildIndex"></param>
    public void LoadScene(int buildIndex)
    {
        string scenePath = SceneUtility.GetScenePathByBuildIndex(buildIndex);
        // an invalid buildIndex returns an empty string as path
        if (scenePath != "")
            SceneManager.LoadScene(buildIndex);
        else
            Debug.LogError("Failed to load scene!");
    }
}
