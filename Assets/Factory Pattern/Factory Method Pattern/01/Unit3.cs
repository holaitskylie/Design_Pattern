using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitType3
{
    Marine,
    Firebat
}

abstract class Unit3
{
    protected UnitType3 type;
    protected string name;
    protected int hp;
    protected int exp;
    public abstract void Attack();
}
