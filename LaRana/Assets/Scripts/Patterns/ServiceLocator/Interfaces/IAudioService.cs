using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAudioService
{
    void PlaySound(audios sound);
    void StopSound(audios sound);
    void PlayAudio(audios sound);
    void StopAudio();
}
