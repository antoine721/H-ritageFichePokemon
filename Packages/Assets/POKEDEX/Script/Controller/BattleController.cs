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
        // Le Pokémon CPU choisit une attaque aléatoirement
        int chosenAttackIndex = Random.Range(0, pokemonCPU._data.attacks.Count);

        // Le Pokémon CPU attaque le Pokémon du joueur
        pokemonCPU.Attack(pokemon, chosenAttackIndex);

        // Vérifier si le Pokémon du joueur est mort
        if (pokemon.IsDead())
        {
            Debug.Log("Le Pokémon " + pokemonCPU._data.label + " a gagné !");
        }
    }
}
