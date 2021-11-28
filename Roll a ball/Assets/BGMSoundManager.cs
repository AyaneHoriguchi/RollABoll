using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMSoundManager : MonoBehaviour
{
    public AudioClip BGMAudioClip;

    public AudioClip GameClear;


    public PlayerPickupItemManager PlayerPickupItemManager;

    public AudioSource BGMAudioSource;
    private void Start()
    {
        BGMAudioSource.clip = BGMAudioClip;
        BGMAudioSource.Play();
    }

    public void PlayGameOverBGM()
    {
        


    }

    public void PlayGameClearBGM()
    {
        if(PlayerPickupItemManager.GetAllPickupItems)
        {
            BGMAudioSource.clip = GameClear;
            BGMAudioSource.Play();
        }

    }

}
