using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[Serializable]
public class PokemonDatas : BaseData
{
    [Serializable]

    public struct Stats
    {
        public int pv;
        public int atk;
        public int def;
        public int atkSpe;
        public int defSpe;
        public int speed;

        public Stats(int pv, int atk, int def, int atkSpe, int defSpe, int speed)
        {
            this.pv = pv;
            this.atk = atk;
            this.def = def;
            this.atkSpe = atkSpe;
            this.defSpe = defSpe;
            this.speed = speed;
        }

        public Stats(Stats statsBase, int coeff)
        {
            pv = statsBase.pv * coeff;
            atk = statsBase.atk * coeff;
            def = statsBase.def * coeff;
            atkSpe = statsBase.atkSpe * coeff;
            defSpe = statsBase.defSpe * coeff;
            speed = statsBase.speed * coeff;
        }
    }

    [Serializable]

    public struct Infos
    {
        public int idNumber;
        public string category;
        public float size;
        public float weight;
        public List<TYPES> types;

        public Infos(int idNumber, string category, float size, float weight, params TYPES[] types)
        {
            this.types = new(types);
            this.idNumber = idNumber;
            this.category = category;
            this.size = size;
            this.weight = weight;
        }
    };

    [Serializable]

    public struct AttackWrapper
    {
        public string label;
        public int level;

        public AttackWrapper(string label, int level)
        {
            this.label = label;
            this.level = level;
        }
    }
    public Sprite icon;

    public Infos info;
    public Stats statsBase;

    public List<AttackWrapper> attacks = new();


    public PokemonDatas(string label, Sprite icon, string caption, Infos info, Stats statsBase) : base(label, caption)
    {
        this.icon = icon;
        this.info = info;
        this.statsBase = statsBase;
    }


    public Stats GetStatsByLvl(int lvl, int evolutionStep) => new(statsBase, (lvl * evolutionStep) / 10);

    public override void DisplayName()
    {
        base.DisplayName();
        Debug.Log("Pokemon : " + label);
    }

}
