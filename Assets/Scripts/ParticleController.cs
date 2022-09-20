using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    [SerializeField] private ParticleSystem _menacingFx;
    
    //Following methods called by Unity event from model tracker.
    public void Activate()
    {
        _menacingFx.Play();
    }

    public void Deactivate()
    {
        _menacingFx.Stop();
    }
}
