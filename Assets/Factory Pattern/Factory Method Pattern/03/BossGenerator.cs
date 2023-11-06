using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class BossGenerator : BossFactory
{
    public BossType type = BossType.EventBoss;

    public GameObject _normalBoss;
    public GameObject _eventBoss;

    public override void CreateBoss(Transform trans)
    {
        if(type == BossType.NormalBoss)
        {
            GameObject boss = Instantiate(_normalBoss) as GameObject;
            boss.transform.position = trans.position;
            boss.transform.localRotation = trans.localRotation;
        }
        else if(type == BossType.EventBoss)
        {
            GameObject boss = Instantiate(_eventBoss) as GameObject;
            boss.transform.position = trans.position;
            boss.transform.localRotation = trans.localRotation;
        }
    }
}