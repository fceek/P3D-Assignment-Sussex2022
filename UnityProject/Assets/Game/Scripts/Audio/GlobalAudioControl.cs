using System.Collections;
using System.Collections.Generic;
using Mono.CompilerServices.SymbolWriter;
using UnityEngine;

public class GlobalAudioControl : MonoBehaviour
{
    [SerializeField] private AudioSource source;

    public void PlayFading(AudioClip clip, float timeout)
    {
        source.clip = clip;
        source.Play();
        var coroutine = FadeInSeconds(timeout);
        StartCoroutine(coroutine);
    }

    private IEnumerator FadeInSeconds(float timeout)
    {
        float step = 0.1f / timeout;
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            source.volume -= step;
            if (source.volume <= step + 0.01f)
            {
                source.Stop();
                source.volume = 1.0f;
                yield break;
            }
        }
    }
}
