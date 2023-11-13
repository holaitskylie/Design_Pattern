using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//종족의 인구를 늘리는 클래스
public abstract class RaceCapacity
{
    //추상 메서드 expand()를 갖는다
    public abstract void expand();
}

public class SupplyDepot : RaceCapacity
{
    public override void expand()
    {
        Debug.Log("Terran Capacity + 8 !!!");
    }
}

public class Pylon : RaceCapacity
{
    public override void expand()
    {
        Debug.Log("Protoss Capacity + 8 !!!");
    }
}