using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDelayed : MonoBehaviour
{
    private AudioSource myAudio;
        
    void Start()
    {
        myAudio = GetComponent<AudioSource>();  
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        myAudio.Play();

        Destroy(this.gameObject, myAudio.clip.length);
    }
}

/*
 * 소리가 사라질 때까지 없어져야 할 게임 오브젝트가 남아 있어 부자연스러움
 */
