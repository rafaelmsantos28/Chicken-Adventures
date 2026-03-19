using UnityEngine;

public class SoundFXController : MonoBehaviour
{
    AudioSource audioSource;

    public AudioClip enemyDeathSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayEnemyDeath()
    {
        audioSource.PlayOneShot(enemyDeathSound);
    }
}
