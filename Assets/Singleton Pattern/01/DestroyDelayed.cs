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
 * �Ҹ��� ����� ������ �������� �� ���� ������Ʈ�� ���� �־� ���ڿ�������
 */
