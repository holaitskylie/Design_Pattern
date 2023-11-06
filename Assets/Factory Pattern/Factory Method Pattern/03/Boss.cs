using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum BossType
{
    NormalBoss,
    EventBoss,
}

/// <summary>
/// abstract class
/// </summary>
abstract class Boss : MonoBehaviour
{
    protected BossType type;
    protected int hp;
    protected int exp;

    //abstract method
    //각종 이벤트에 맞는 액션으로 Attack을 하도록 구현하기 위함
    public abstract void Attack();
}