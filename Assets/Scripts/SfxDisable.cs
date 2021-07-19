using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxDisable : MonoBehaviour
{
    public GameObject gameObjectSelect;

    //Disables Game Object on run
    public void Setup()
    {
        gameObjectSelect.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        Setup();
    }
}
