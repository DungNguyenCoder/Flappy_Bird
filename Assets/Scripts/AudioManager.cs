using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    public AudioClip die;
    public AudioClip hit;
    public AudioClip point;
    public AudioClip swoosh;
    public AudioClip wing;

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    } 
}