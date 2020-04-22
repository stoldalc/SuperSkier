using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameSoundMgr : MonoBehaviour
{
    public AudioSource boatAndWaterSounds;

    private void Start()
    {
        
    }
    private void Update()
    {
        
    }


    public void backgroundNoise()
    {
        boatAndWaterSounds.Play();
    }
}
