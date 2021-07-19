using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchRandomiser : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = Random.Range(0.9f, 2f);
    }
}
