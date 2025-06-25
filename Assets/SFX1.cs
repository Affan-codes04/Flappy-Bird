using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX1 : MonoBehaviour
{
    public AudioSource src;
    public AudioClip clip1,clip2,clip3;
    public void coin(){
        src.clip = clip1;
        src.Play();
    }
    public void jump(){
        src.clip = clip2;
        src.Play();
    }
    public void over(){
        src.PlayOneShot(clip3);
    }
}
