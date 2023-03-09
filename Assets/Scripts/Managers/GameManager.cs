using UnityEngine;

public class GameManager : MonoBehaviour
{
    private ScenesManager scenesManager;
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
        scenesManager = new ScenesManager();
    }

    public static void TestFunction()
    {
        Debug.Log("The GameManager is being used!");
    }

    public void ChangeScene(string sceneName)
    {
        scenesManager.LoadScene(sceneName);
    }
}
