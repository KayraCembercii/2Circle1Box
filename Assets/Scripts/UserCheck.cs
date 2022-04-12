using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserCheck
{
    string _p1Name, _p2Name;
    public string _textControl;

    public string Player1 {
        get
        {
            return _p1Name;
        }

        set
        {
            if (value.Length < 3)
            {
                _textControl = "Character name cannot be shorter than 3 letters.";
            }
            else
            {
                _p1Name = value;
            }
        }
    }

    public string Player2
    {
        get
        {
            return _p2Name;
        }

        set
        {
            if (value.Length < 3)
            {
                _textControl = "Character name cannot be shorter than 3 letters.";
            }
            else
            {
                _p2Name = value;
            }
        }
    }


}
