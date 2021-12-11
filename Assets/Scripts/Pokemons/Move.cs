using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
    public MoveBase _base;
    public int pp;

    public Move(MoveBase mBase)
    {
        _base = mBase;
        pp = _base.GetPp();
    }

    public MoveBase GetBase()
    {
        return _base;
    }

    public int GetPp()
    {
        return pp;
    }
}
