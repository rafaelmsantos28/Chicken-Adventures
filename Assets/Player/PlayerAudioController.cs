using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{

    AudioSource audioSource;

    public AudioClip getItemSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayGetItem()
    {
        audioSource.PlayOneShot(getItemSound);
    }
}
