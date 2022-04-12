using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Score
{
    int _scoreP1 = 0, _scoreP2 = 0, _index;
    List<int> _scoreListP1 = new List<int>();
    int[] _scoreArrayP2 = new int[11];

    public int ScoreP1
    {
        get
        {
            return _scoreP1;
        }
        private set
        {
        }
    }
    public int ScoreP2
    {
        get
        {
            return _scoreP2;
        }
        private set
        { }
    }
    public void ScoreListMethod()
    {
        _scoreListP1.Add(1);
        _scoreP1 = _scoreListP1.Count;
    }
    public void ScoreArrayMethod()
    {
        _scoreArrayP2[_index] = 1;
        _scoreP2 = _scoreArrayP2.Sum();
        _index++;
    }
}
