using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class VoiceLineAudioController : MonoBehaviour
{
    private AudioSource _audioSource;
    [SerializeField] private List<AudioClip> _voiceLineClips;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    //Called by Unity event in target tracker's event handler.
    public void PlayRandomVoiceLine()
    {
        _audioSource.Stop();
        if (_voiceLineClips.Count < 1)
        {
            Debug.LogError("No audio clips in voice line list!");
        }
        int index = Random.Range(0, _voiceLineClips.Count-1);
        if (_voiceLineClips[index] != null)
        {
            _audioSource.PlayOneShot(_voiceLineClips[index]);
        }
    }
}
