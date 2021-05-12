using UnityEngine;

public class LevelManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f;

    void Start()
    {
        FindObjectOfType<ThemeMusic>().Play();
    }

    public void EndGame()
    {

        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            FindObjectOfType<LooseMusic>().Play();
            FindObjectOfType<LevelLoader>().Load(Loader.Scene.Loose);
        }

    }

    public void FinishGame()
    {

        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            FindObjectOfType<VictoryMusic>().Play();
            Next();
        }
    }

    public void Restart()
    {
        FindObjectOfType<LevelLoader>().Load(FindObjectOfType<GameManager>().currentLevel);
    }

    public void Next()
    {
        FindObjectOfType<LevelLoader>().Load(FindObjectOfType<GameManager>().nextScene);
    }
    public bool IsGameOver()
    {
        return gameHasEnded;
    }
}
