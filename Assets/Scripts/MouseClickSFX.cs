using UnityEngine;

public class MouseClickSFX : MonoBehaviour
{
    public void Play()
    {
        GetComponent<AudioSource>().Play();
    }
    
    public void Pause()
    {
        GetComponent<AudioSource>().Pause();
    }
    
    public void Stop()
    {
        GetComponent<AudioSource>().Stop();
    }
}
