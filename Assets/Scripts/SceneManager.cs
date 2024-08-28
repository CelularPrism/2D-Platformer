public static class SceneManager
{
    public static void ReloadScene()
    {
        var activeScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        UnityEngine.SceneManagement.SceneManager.LoadScene(activeScene.buildIndex);
    }
}
