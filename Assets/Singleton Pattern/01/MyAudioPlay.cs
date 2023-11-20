using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAudioPlay : MonoBehaviour
{
    public AudioClip clip;

    private void OnCollisionEnter(Collision collision)
    {
        //AudioManager에서 싱글톤 인스턴스를 얻어와
        //해당 인스턴스의 Play()를 호출한다
        AudioManager.Instance().Play(clip);
        Destroy(this.gameObject);
    }
}
