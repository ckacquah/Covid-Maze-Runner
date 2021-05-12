using UnityEngine.SceneManagement;

public static class Loader
{
    public enum Scene
    {
        Level01,
        Level02,
        Credits,
        Menu,
        Win,
        Loose,
    };
    public static void Load(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
}
