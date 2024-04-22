using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatController : MonoBehaviour
{
    [SerializeField] private Image _imgPv;
    [SerializeField] private Image _imgAtk;
    [SerializeField] private Image _imgDef;
    [SerializeField] private Image _imgAtkSpe;
    [SerializeField] private Image _imgDefSpe;
    [SerializeField] private Image _imgSpeed;

    [SerializeField] private Text _txtPv;
    [SerializeField] private Text _txtAtk;
    [SerializeField] private Text _txtDef;
    [SerializeField] private Text _txtAtkSpe;
    [SerializeField] private Text _txtSpeed;
    [SerializeField] private Text _txtDefSpe;

    public void RefreshUi(PokemonDatas.Stats stats)
    {
        float baseValue = 15;

        _imgPv.fillAmount = (float)(stats.pv / baseValue);
        _imgAtk.fillAmount = (float)(stats.atk / baseValue);
        _imgDef.fillAmount = (float)(stats.def / baseValue);
        _imgAtkSpe.fillAmount = (float)(stats.atkSpe / baseValue);
        _imgDefSpe.fillAmount = (float)(stats.defSpe / baseValue);
        _imgSpeed.fillAmount = (float)(stats.speed / baseValue);

        _txtPv.text = $"PV [{stats.pv}/{baseValue}]";
        _txtAtk.text =$"ATK [{stats.atk}/{baseValue}]";
        _txtDef.text = $"DEF [{stats.def}/{baseValue} ]";
        _txtAtkSpe.text = $"ASPE [{stats.atkSpe}/{baseValue}]";
        _txtDefSpe.text = $"DSPE [{stats.defSpe}/{baseValue}]";
        _txtSpeed.text = $"VIR [{stats.speed}/{baseValue}]";

    }

}
