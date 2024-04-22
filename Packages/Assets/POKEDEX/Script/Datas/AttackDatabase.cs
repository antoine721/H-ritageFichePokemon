using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[CreateAssetMenu(fileName = "NewAttackDatabase", menuName = "Database/Attack", order = 0)]


public class AttackDatabase : ScriptableObject 
{
    public List<AttackData> datas = new();
}


