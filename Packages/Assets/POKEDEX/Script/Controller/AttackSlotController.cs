using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackSlotController : MonoBehaviour
{
    [SerializeField] private Text _txtLabel;
    [SerializeField] private Button _btAtk;

    private AttackData _data;

    private void Awake()
    {
        _btAtk = GetComponent<Button>();
        _txtLabel = GetComponentInChildren<Text>();


        _btAtk.onClick.AddListener(DisplayAttack);
    }

    public void Init(string label)
    {
        _data = DatabaseManager.GetInstance().GetAttackData(label);
        _txtLabel.text = _data.label;
    }

    private void DisplayAttack()
    {
        Debug.Log($"{BattleController.CurrentPokemon._data.label} utilise {_txtLabel.text}");
    }
}
