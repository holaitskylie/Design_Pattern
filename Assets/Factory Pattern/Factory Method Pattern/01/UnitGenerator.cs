using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//팩토리를 만들기 위한 추상 클래스
abstract class UnitGenerator
{
    public List<Unit3> units = new List<Unit3>();

    public List<Unit3> getUnits()
    {
        return units;
    }

    //Factory Method & abstrack Mothod
    public abstract void CreateUnits();
}