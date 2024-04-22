using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "Pokemon", menuName = "Database/Pokemon", order = 0)]
public class PokemonDataBase : ScriptableObject
{
    public List<PokemonDatas> datas = new();



    public void InitData()
    {
        datas.RemoveAll(data => data.info.idNumber == 0);
    }

}
