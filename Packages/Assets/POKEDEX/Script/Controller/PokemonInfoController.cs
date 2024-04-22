using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

    
public class PokemonInfoController : MonoBehaviour
{
    [SerializeField] private Image _imgIcon;
    [SerializeField] private TextMeshProUGUI _txtName;
    [SerializeField] private TextMeshProUGUI _txtSize;
    [SerializeField] private TextMeshProUGUI _txtWeight;
    [SerializeField] private TextMeshProUGUI _txtCaption;

    [SerializeField] private Button _btPrevious;
    [SerializeField] private Button _btNext;

    StatController _statController;
    private int id;

    private void Awake()
    {
        _statController = FindObjectOfType<StatController>();
    }

    void Start()
    {
        OnChange(0);
    }


    public void OnChange(int value)
    {
        id += value;

        PokemonDatas dataCurrent = DatabaseManager.GetInstance().GetData(id);

        RefreshUI(dataCurrent);
        _statController.RefreshUi(dataCurrent.statsBase);

        PokemonDatas dataPrev = DatabaseManager.GetInstance().GetData(id-1);
        _btPrevious.transform.GetChild(0).GetComponent<Image>().sprite = dataPrev.icon;
        PokemonDatas dataNext = DatabaseManager.GetInstance().GetData(id +1);
        _btNext.transform.GetChild(0).GetComponent<Image>().sprite = dataNext.icon;


    }

    private void RefreshUI(PokemonDatas data)
    {
        if (_imgIcon != null)
        {
            _imgIcon.sprite = data.icon;
        }
        else
        {
            Debug.LogError("_imgIcon is null.");
        }


        _txtName.text = $"<b>N° {data.info.idNumber:0000} | {data.label}</b>";

        _txtSize.text = $"{data.info.size:f1}m";

        _txtWeight.text = $"{data.info.weight:f1} kg";

        _txtCaption.text = $"{ data.caption }";

    }
}
