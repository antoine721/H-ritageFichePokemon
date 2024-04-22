using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokemonController : MonoBehaviour
{
    [SerializeField] private Text _txtLabel;
    [SerializeField] private Image _imgIcone;

    [Header("PV")]
    [SerializeField] private Image _imgPv;
    [SerializeField] private Text _txtPv;

    [SerializeField] private List<AttackSlotController> _atkSlots = new();

    public PokemonDatas _data { get; private set; }
    private int _currentLife;

    public void Init(PokemonDatas data)
    {
        _data = data;
        _txtLabel.text = _data.label;
        _imgIcone.sprite = _data.icon;

        _currentLife = data.statsBase.pv;

        foreach (AttackSlotController slot in _atkSlots)
        {
            var id = _atkSlots.IndexOf(slot);
            slot.Init(data.attacks[id].label);
        }

        RefreshUI();
    }

    private void RefreshUI()
    {
        _txtPv.text = $"{_currentLife:00} / {_data.statsBase.pv:00}";
    }

    public bool IsDead()
    {
        return _currentLife <= 0;
    }


    public void Attack(PokemonController target, int attackIndex)
    {
        if (!IsDead())
        {
            // Obtenir les données de l'attaque
            AttackData attackData = DatabaseManager.GetInstance().GetAttackData(_data.attacks[attackIndex].label);

            // Infliger des dégâts au Pokémon cible
            target.TakeDamage(attackData.degat);
        }
    }

    public void TakeDamage(int damage)
    {
        // Réduire la vie courante
        _currentLife -= damage;

        // Actualiser l'interface utilisateur
        RefreshUI();
    }

}
