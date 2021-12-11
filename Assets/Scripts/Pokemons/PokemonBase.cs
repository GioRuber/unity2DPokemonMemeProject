using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon/Create new Pokemon")]
public class PokemonBase : ScriptableObject
{
    [SerializeField] string name;
    
    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] PokemonType mainType;
    [SerializeField] PokemonType secondaryType;

    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefense;
    [SerializeField] int speed;

    [SerializeField] List<LearnableMove> learnableMoves;

    public string GetName()
    {
        return name;
    }

    public string GetDescription()
    {
        return description;
    }

    public Sprite GetFrontSprite()
    {
        return frontSprite;
    }

    public Sprite GetBackSprite()
    {
        return backSprite;
    }

    public PokemonType GetMainType()
    {
        return mainType;
    }

    public PokemonType GetSecondaryType()
    {
        return secondaryType;
    }

    public int GetMaxHp()
    {
        return maxHp;
    }

    public int GetAttack()
    {
        return attack;
    }

    public int GetDefense()
    {
        return defense;
    }

    public int GetSpAttack()
    {
        return spAttack;
    }

    public int GetSpDefense()
    {
        return spDefense;
    }

    public int GetSpeed()
    {
        return speed;
    }

    public List<LearnableMove> GetLearnableMoves()
    {
        return learnableMoves;
    }
}

[System.Serializable]
public class LearnableMove
{
    [SerializeField] MoveBase moveBase;
    [SerializeField] int level;

    public MoveBase GetMoveBase()
    {
        return moveBase;
    }

    public int GetLevel()
    {
        return level;
    }
}

public enum PokemonType
{
    None,
    Normal,
    Fire,
    Water,
    Electric,
    Grass,
    Ice,
    Fighting,
    Poison,
    Ground,
    Flying,
    Psychic,
    Bug,
    Rock,
    Ghost,
    Dragon
}
