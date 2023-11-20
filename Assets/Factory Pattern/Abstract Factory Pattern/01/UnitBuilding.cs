using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//종족의 인구를 늘리기 위한 건물을 짓는 클래스
public abstract class UnitBuilding
{
    public abstract void produce();
}

public class Barracks : UnitBuilding
{
    public override void produce()
    {
        Debug.Log("Terran Unit 생산!!!");
    }
}

public class Gateway : UnitBuilding
{
    public override void produce()
    {
        Debug.Log("Protoss Unit 생산!!!");
    }
}