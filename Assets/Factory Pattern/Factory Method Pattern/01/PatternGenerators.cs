using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//추상 클래스<UnitGenerator>를 이용해 만든 구상 클래스A(ConcreteCreator)
class PatternAGenerator : UnitGenerator
{
    //<UnitGenerator>의 추상 메서드 CreateUnits() 오버라이드
    public override void CreateUnits()
    {
        units.Add(new Marine3());
        units.Add(new Marine3());
        units.Add(new Marine3());
        units.Add(new Marine3());
        units.Add(new Marine3());
    }
}

//추상 클래스를 이용해 만든 구상 클래스B(ConcreteCreator)
class PatternBGenerator : UnitGenerator
{
    //<UnitGenerator>의 추상 메서드 CreateUnits() 오버라이드
    public override void CreateUnits()
    {
        units.Add(new Firebat3());
        units.Add(new Firebat3());
        units.Add(new Firebat3());
        units.Add(new Marine3());
        units.Add(new Marine3());
        units.Add(new Marine3());
        units.Add(new Marine3());
        
    }
}