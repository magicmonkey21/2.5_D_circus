using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsScript : MonoBehaviour
{
    public AudioClip[] soundsEffects;
    public AudioSource effectsSource;
    
    public void Hover() {
        effectsSource.PlayOneShot(soundsEffects[0]);
    }

    public void Clicked()
    {
        effectsSource.PlayOneShot(soundsEffects[1]);
    }

    public void OnDice()
    {
        effectsSource.loop = true;
        effectsSource.clip = soundsEffects[2];
        effectsSource.Play();
    }

    public void CancelButton() {
        effectsSource.PlayOneShot(soundsEffects[3]);
    }

    public void PlayButton() {
        effectsSource.PlayOneShot(soundsEffects[4]);
    }

    public void NameField() {
        effectsSource.PlayOneShot(soundsEffects[5]);
    }
}
