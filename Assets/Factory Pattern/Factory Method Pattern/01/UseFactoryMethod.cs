using System.Collections;
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

    //Ÿ���� �� ���� �ִٴ� �͸� �ȴ�
    public void DoMakeTypeA()
    {
        //������ ��������� ���⼭�� �𸥴�.
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
        //������ ��������� ���⼭�� �𸥴�.
        unitGenerators[1].CreateUnits();
        //unitGenerators[1].units[1].Attack();

        List<Unit3> units = unitGenerators[1].getUnits();
        foreach (Unit3 unit in units)
        {
            unit.Attack();
        }

    }
}
