using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //객체가 생성된 이후로 계속해서 누적되는 값
    int nMyPoint = 0;

    //static 키워드로 자기 자신을 변수로 가진다
    //static으로 선언된 순간 메모리에 이미 올라가짐
    static AudioManager _instance = null;
    public static AudioManager Instance()
    {
        return _instance;
    }
   
    void Start()
    {
        if( _instance == null )
            _instance = this;
        
    }

    public void Play(AudioClip clip)
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }

    public int GetPoint()
    {
        nMyPoint = nMyPoint + 1;
        return nMyPoint;    
    }

}
