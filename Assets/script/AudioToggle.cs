using UnityEngine;

public class AudioToggle : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component
    public KeyCode toggleKey = KeyCode.Space; // Key to toggle audio playback

    void Update()
    {
        // Check for key press
        if (Input.GetKeyDown(toggleKey))
        {
            ToggleAudio();
        }
    }

    void ToggleAudio()
    {
        if (audioSource.isPlaying)
        {
            // Pause the audio if it is currently playing
            audioSource.Pause();
        }
        else
        {
            // Play the audio if it is currently paused
            audioSource.Play();
        }
    }
}
