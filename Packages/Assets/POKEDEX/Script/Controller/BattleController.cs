using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour
{
    public PokemonController pokemon;
    public PokemonController pokemonCPU;

    public static PokemonController CurrentPokemon;

    void Start()
    {
        pokemon.Init(DatabaseManager.GetInstance().GetData(0));
        pokemonCPU.Init(DatabaseManager.GetInstance().GetData(2));

        CurrentPokemon = pokemon;
    }

    public void PerformAttack()
    {
        // Le Pok�mon CPU choisit une attaque al�atoirement
        int chosenAttackIndex = Random.Range(0, pokemonCPU._data.attacks.Count);

        // Le Pok�mon CPU attaque le Pok�mon du joueur
        pokemonCPU.Attack(pokemon, chosenAttackIndex);

        // V�rifier si le Pok�mon du joueur est mort
        if (pokemon.IsDead())
        {
            Debug.Log("Le Pok�mon " + pokemonCPU._data.label + " a gagn� !");
        }
    }
}
