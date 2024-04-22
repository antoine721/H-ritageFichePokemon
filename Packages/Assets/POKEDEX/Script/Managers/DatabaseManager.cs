using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;





public class DatabaseManager : MonoBehaviour
{
    public static DatabaseManager instance;

    public PokemonDataBase database;
    public AttackDatabase attackDatabase;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        database.InitData();
    }

    public PokemonDatas GetData(int id)
    {
        var max = database.datas.Count;
        id = id < 0 ? max - 1 : id >= max ? 0 : id;

        return database?.datas[id];
    }

    public AttackData GetAttackData(string label)
    {
        return attackDatabase?.datas.Find(x => x.label.ToLower().Contains(label.ToLower()));
    }

    public static DatabaseManager GetInstance()
    {
        if (instance == null)
        {
            Debug.LogError("DatabaseManager instance is null.");
        }

        return instance;
    }
}
