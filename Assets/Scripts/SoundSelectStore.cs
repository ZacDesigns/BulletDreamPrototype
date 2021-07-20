using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSelectStore : MonoBehaviour
{

    private static SoundSelectStore selectSoundInstance;
    private GameObject sfxButtonSelect;
    // Start is called before the first frame update
    void Awake()
    {
        if (selectSoundInstance == null)
        {
            selectSoundInstance = this;
        }
        DontDestroyOnLoad(this);
    }

}
