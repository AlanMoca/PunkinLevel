using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceSounds : MonoBehaviour
{
    [SerializeField] private AudioClip[] bounceSound;
    [SerializeField] private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter( Collision collision )
    {
        PlayBoundSounce();
    }

    private void PlayBoundSounce()
    {
        if ( bounceSound.Length == 0 )
        {
            return;
        }
        int index = Random.Range(0, bounceSound.Length);
        audioSource.pitch = Random.Range( 0.0f, 1.2f );
        audioSource.PlayOneShot( bounceSound[index] );
    }
}
