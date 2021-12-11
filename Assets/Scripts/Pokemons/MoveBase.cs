using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Pokemon/Create a new move")]
public class MoveBase : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] PokemonType type;
    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int pp;

    public string GetName()
    {
        return name;
    }

    public string GetDescription()
    {
        return description;
    }

    public PokemonType GetPokemonType()
    {
        return type;
    }

    public int GetPower()
    {
        return power;
    }

    public int GetAccuracy()
    {
        return accuracy;
    }

    public int GetPp()
    {
        return pp;
    }
}
