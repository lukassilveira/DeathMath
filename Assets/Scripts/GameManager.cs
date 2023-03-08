using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance is null)
                Debug.LogError("GameManager is null");
            return instance;
        }
    }

    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This function is used for debug purposes
    public static void TestFunction()
    {
        Debug.Log("The GameManager is being used!");
    }

    // This function should be called when the game needs to change scene
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
