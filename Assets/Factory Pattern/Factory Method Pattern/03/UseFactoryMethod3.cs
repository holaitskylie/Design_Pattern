﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseFactoryMethod3 : MonoBehaviour
{
    BossGenerator factory = null;
    public Text desc;

    private void Start()
    {
        factory = GetComponent<BossGenerator>();

        if (factory.type == BossType.NormalBoss)
        {
            desc.text = "Normal Boss";
        }
        else if(factory.type == BossType.EventBoss)
        {
            desc.text = "Event Boss";
        }

        //로직에 따라 특정 위치 지정 
        Transform trans = this.gameObject.transform;
       
        //무엇이 만들어질지는 여기서는 모른다
        factory.CreateBoss(trans);
    }
}
