﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseFactoryMethod : MonoBehaviour
{
    UnitGenerator[] unitGenerators = null;

    
    void Start()
    {
        unitGenerators = new UnitGenerator[2];
        unitGenerators[0] = new PatternAGenerator();
        unitGenerators[1] = new PatternBGenerator();        
    }

    //타입이 두 가지 있다는 것만 안다
    public void DoMakeTypeA()
    {
        //무엇이 만들어질지 여기서는 모른다.
        unitGenerators[0].CreateUnits();
        //unitGenerators[0].units[0].Attack();

        List<Unit3> units = unitGenerators[0].getUnits();
        foreach (Unit3 unit in units)
        {
            unit.Attack();
        }
    }

    public void DoMakeTypeB()
    {
        //무엇이 만들어질지 여기서는 모른다.
        unitGenerators[1].CreateUnits();
        //unitGenerators[1].units[1].Attack();

        List<Unit3> units = unitGenerators[1].getUnits();
        foreach (Unit3 unit in units)
        {
            unit.Attack();
        }

    }
}
