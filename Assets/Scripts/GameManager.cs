using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameManager _static { get; private set; }
    private void Awake()
    {
        Singleton();
    }

    void Singleton()
    {
        if (_static == null)
        {
            _static = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
