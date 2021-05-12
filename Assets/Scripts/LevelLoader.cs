using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour
{

    public Animator transition;
    public float transitionTime;

    public void Load(Loader.Scene scene)
    {
        if (scene == Loader.Scene.Level01 || scene == Loader.Scene.Level02)
        {
            FindObjectOfType<GameManager>().currentLevel = scene;

            if (scene == Loader.Scene.Level01)
            {
                FindObjectOfType<GameManager>().nextScene = Loader.Scene.Level02;
            }
            else
            {
                FindObjectOfType<GameManager>().nextScene = Loader.Scene.Win;
            }
        }
        else
        {
            if(scene == Loader.Scene.Menu)
            {
                FindObjectOfType<GameManager>().nextScene = Loader.Scene.Level01;
            }
            else if (scene == Loader.Scene.Win)
            {
                FindObjectOfType<GameManager>().nextScene = Loader.Scene.Credits;
            }
            else if (scene == Loader.Scene.Credits)
            {
                FindObjectOfType<GameManager>().nextScene = Loader.Scene.Menu;
            }
        }
        StartCoroutine(LoadLevel(scene));
    }

    IEnumerator LoadLevel(Loader.Scene scene)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        Loader.Load(scene);
    }
}
