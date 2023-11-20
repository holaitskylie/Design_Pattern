using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The 'ConCreteFactory1' class
/// </summary>
public class TerranFactory2 : RaceFactory2
{
    public GameObject supply;
    public GameObject barracks;

    public override GameObject makeCapacityBuilding()
    {
        //return new SupplyDepot();
        return Instantiate(supply, new Vector3(-1.0f, 1.0f, 0.0f), Quaternion.identity);
    }

    public override GameObject makeUnitBuilding()
    {
        //return new Barracks();
        return Instantiate(barracks, new Vector3(1.0f, 0.5f, 0.0f), Quaternion.identity);
    }


}
