using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public bool isplay=true;

    public void PlayOrPause(AudioSource au)
    {
        isplay = !isplay;
        if (isplay)
        {
            au.Play();
            transform.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            au.Pause();
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
