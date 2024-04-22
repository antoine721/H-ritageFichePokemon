using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AttackData : BaseData

{
    public enum CATEGORIES
    {
        PHYSICAL,
        PSYCHIC,
        STATUT,
        SPECIAL
    }

    public CATEGORIES category = CATEGORIES.PHYSICAL;
    public TYPES types;
    public int degat;
    public int precision;

    public AttackData(string label, string caption) : base(label, caption)
    {
    }
    public override void DisplayName()
    {
        Debug.Log("Attaque : " + label);
        base.DisplayName();
    }
}