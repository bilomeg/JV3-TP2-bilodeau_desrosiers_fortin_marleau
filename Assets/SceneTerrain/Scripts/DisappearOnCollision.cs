using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnCollision : MonoBehaviour
{
    [SerializeField] private GameObject crowbarObject;
    [SerializeField] private AudioClip disappearanceSound;

    private AudioSource audioSource;

    private void Start()
    {
        // Get or add an AudioSource component to the GameObject.
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Set the audio clip for the disappearance sound.
        audioSource.clip = disappearanceSound;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == crowbarObject)
        {
            // Play the disappearance sound using PlayOneShot.
            if (disappearanceSound != null)
            {
                audioSource.PlayOneShot(disappearanceSound);
                
                // Delay the destruction of the GameObject to allow the sound to play.
                Invoke("DestroyGameObject", disappearanceSound.length);
            }
            else
            {
                // If no sound is available, destroy the GameObject immediately.
                DestroyGameObject();
            }
        }
    }

    // Method to destroy the GameObject.
    private void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
