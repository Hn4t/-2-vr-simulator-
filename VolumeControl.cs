using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play(); // �������� ��������������� ������
    }

    public void PauseMusic()
    {
        audioSource.Pause(); // ������ ������ �� �����
    }

    public void ResumeMusic()
    {
        audioSource.UnPause(); // ������������ ���������������
    }

    public void StopMusic()
    {
        audioSource.Stop(); // ������������� ������
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume; // ������������� ���������
    }
}