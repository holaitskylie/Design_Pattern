using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Race_2
{
    Terran,
    Protoss,
    Zerg
}

/// <summary>
/// The 'AbstractFactory' abstract class
/// </summary>
public abstract class RaceFactory2 : MonoBehaviour
{
   public abstract GameObject makeCapacityBuilding();
   public abstract GameObject makeUnitBuilding();
}
