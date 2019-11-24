using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    public enum AlienState
    {
        AlienTrans, AlienOpq
    }

    [SerializeField] private AlienState alienCurrentState = AlienState.AlienOpq;
    [SerializeField] private Renderer _renderer;
    [SerializeField] private Color alphaTrans = Color.white;

    public AlienState AlienCurrentState {
        get => alienCurrentState;
        private set => alienCurrentState = value;
    }

    //Other Option
    public void BecomeTras() => _renderer.material.color = AlienCurrentState == AlienState.AlienTrans == true ? alphaTrans : Color.white;     //The option "Color.White" reset the alpha value to 255.

    public void BecomeLit()
    {
        AlienCurrentState = AlienState.AlienTrans;
        _renderer.material.color = alphaTrans;
    }

    public void BecomeUnLit()
    {
        AlienCurrentState = AlienState.AlienOpq;
        _renderer.material.color = Color.white;
    }

    //[SerializeField] private Renderer _renderer;
    //[SerializeField] private Color alphaTrans = Color.white;

    //private KillPlayer killPlayer;
    //private float fadeToOpaqueTimer;
    //private float totalFadeTime = 0.5f;

    //private void Awake()
    //{
    //    killPlayer = GetComponent<KillPlayer>();
    //}

    //private void Update()
    //{
    //    if ( fadeToOpaqueTimer > 0 )
    //    {
    //        fadeToOpaqueTimer -= Time.deltaTime;
    //        if ( fadeToOpaqueTimer <= 0 )
    //        {
    //            FinalizeUnlighting();
    //        }
    //        else
    //        {
    //            FadeAlpha();
    //        }
    //    }
    //}

    //private void FadeAlpha()
    //{
    //    float pct = fadeToOpaqueTimer / totalFadeTime;
    //    _renderer.material.color = Color.Lerp( alphaTrans, Color.white, pct );
    //}

    //public void BecomeLit()
    //{
    //    fadeToOpaqueTimer = 0;
    //    killPlayer.enabled = false;
    //    _renderer.material.color = alphaTrans;
    //}

    //private void FinalizeUnlighting()
    //{
    //    killPlayer.enabled = true;
    //    _renderer.material.color = Color.white;
    //}

    //public void BecomeUnLit()
    //{
    //    fadeToOpaqueTimer = totalFadeTime;
    //}

}