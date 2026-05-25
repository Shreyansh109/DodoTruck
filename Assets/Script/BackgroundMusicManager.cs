using UnityEngine;

public class BackgroundMusicManager : MonoBehaviour
{
    public AudioSource UpperWordMusic;
    public AudioSource UnderWordMusic;
    void Start()
    {
        UnderWordMusic.Play();
        UnderWordMusic.Pause();
    }
    public void PlayUpper()
    {
        UpperWordMusic.UnPause();
        UnderWordMusic.Pause();
    }

    public void PlayUnder()
    {
        UnderWordMusic.UnPause();
        UpperWordMusic.Pause();
    }
}
