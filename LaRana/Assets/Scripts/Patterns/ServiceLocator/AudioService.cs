using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioService : IAudioService
{
    public void PlayAudio(audios sound)
    {
        AudioClip clip = Resources.Load<AudioClip>($"Audio/{sound.ToString()}");

        if (clip != null)
            AudioSource.PlayClipAtPoint(clip, Vector3.zero);
        else
            Debug.Log($"No se encontro {sound}");
    }

    public void PlaySound(audios sound)
    {
        throw new System.NotImplementedException();
    }

    public void StopAudio()
    {
        throw new System.NotImplementedException();
    }

    public void StopSound(audios sound)
    {
        throw new System.NotImplementedException();
    }
}

