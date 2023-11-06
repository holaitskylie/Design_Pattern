using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ConcreteCreator class
/// </summary>
public class DatabaseGenerator : DatabaseFactory
{
    public DBType dbType = DBType.MySQL;

    public override Database MakeDatabase()
    {
        if(dbType == DBType.MySQL)
        {
            Debug.Log("MySQL use..");
            return new MySQL();
        }
        else if(dbType == DBType.Oracle)
        {
            Debug.Log("Oracle use..");
            return new Oracle();
        }
        else if (dbType == DBType.Infomix)
        {
            Debug.Log("Infomix use..");
            return new Infomix();
        }
        else
        {
            return null;
        }
    }
}
