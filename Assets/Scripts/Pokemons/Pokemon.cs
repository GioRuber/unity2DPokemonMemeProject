using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{
    PokemonBase _base;
    int level;

    public int hp;

    public List<Move> moves;

    public Pokemon(PokemonBase pBase, int pLevel)
    {
        _base = pBase;
        level = pLevel;
        hp = _base.GetMaxHp();

        moves = new List<Move>();
        foreach(var move in _base.GetLearnableMoves())
        {
            if (move.GetLevel() <= level)
            {
                moves.Add(new Move(move.GetMoveBase()));
            }

            if (moves.Count >= 4)
            {
                break;
            }
        }
    }

    public int GetAttack()
    {
        return Mathf.FloorToInt(( _base.GetAttack() * level ) / 100f) + 5;
    }
    
    public int GetDefense()
    {
        return Mathf.FloorToInt((_base.GetDefense() * level) / 100f) + 5;
    }

    public int GetSpAttack()
    {
        return Mathf.FloorToInt((_base.GetSpAttack() * level) / 100f) + 5;
    }

    public int GetSpDefense()
    {
        return Mathf.FloorToInt((_base.GetSpDefense() * level) / 100f) + 5;
    }

    public int GetSpeed()
    {
        return Mathf.FloorToInt((_base.GetSpeed() * level) / 100f) + 5;
    }

    public int GetMaxHp()
    {
        return Mathf.FloorToInt((_base.GetMaxHp() * level) / 100f) + 10;
    }

    public List<Move> GetMoves()
    {
        return moves;
    }

    public int GetHp()
    {
        return hp;
    }
}
