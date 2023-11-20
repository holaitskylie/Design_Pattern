using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//팩토리 메서드가 사용된 스크립트
//최정 사용하는 코드는 FactoryMethodUse.cs

public class FactoryMethod : MonoBehaviour
{
    public Race2 type = Race2.Terran;

    public RaceFactory getFactory()
    {
        RaceFactory facotry = null;

        switch (type)
        {
            case Race2.Terran:
                facotry = new TerranFactory();
                break;
            case Race2.Protoss:
                facotry = new ProtossFactory();
                break;
        }

        return facotry;
    }
}
