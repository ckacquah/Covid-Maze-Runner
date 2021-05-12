using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        FindObjectOfType<LevelLoader>().Load(Loader.Scene.Level01);
    }


    public void ShowMenu()
    {
        FindObjectOfType<LevelLoader>().Load(Loader.Scene.Menu);
    }


    public void ShowCredit()
    {
        FindObjectOfType<LevelLoader>().Load(Loader.Scene.Credits);
    }

    public void PlayClickAudio()
    {
        FindObjectOfType<ThemeMusic>().Stop();
        FindObjectOfType<LooseMusic>().Stop();
        FindObjectOfType<VictoryMusic>().Stop();
        FindObjectOfType<MouseClickSFX>().Stop();
        FindObjectOfType<MouseClickSFX>().Play();
    }
}
