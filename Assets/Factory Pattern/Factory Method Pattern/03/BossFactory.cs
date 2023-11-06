using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class BossFactory : MonoBehaviour
{
    //Factory Method
    public abstract void CreateBoss(Transform trans);
}