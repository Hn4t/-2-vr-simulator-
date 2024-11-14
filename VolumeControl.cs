using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play(); // Начинаем воспроизведение музыки
    }

    public void PauseMusic()
    {
        audioSource.Pause(); // Ставим музыку на паузу
    }

    public void ResumeMusic()
    {
        audioSource.UnPause(); // Возобновляем воспроизведение
    }

    public void StopMusic()
    {
        audioSource.Stop(); // Останавливаем музыку
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume; // Устанавливаем громкость
    }
}