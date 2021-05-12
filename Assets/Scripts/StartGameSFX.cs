using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameSFX : MonoBehaviour
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
