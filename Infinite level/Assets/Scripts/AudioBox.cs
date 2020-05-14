using UnityEngine;

public class AudioBox : MonoBehaviour
{
    public AudioClip click;
    public AudioClip door;
    public AudioClip damage;
    public AudioClip crystal;

    public void AudioPlay(AudioClip ac)
    {
        GetComponent<AudioSource>().clip = ac;
        GetComponent<AudioSource>().Play();
    }
}
