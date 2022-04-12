using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LoginControl : MonoBehaviour
{
    [SerializeField] InputField _player1, _player2;
    [SerializeField] Text _infoText;
    public static string _mainP1, _mainP2;
    UserCheck _user = new UserCheck();

    public void CheckButton()
    {
        _user.Player1 = _player1.text;
        _user.Player2 = _player2.text;
        _infoText.text = _user._textControl;
        if (_player1.text.Length >= 3 || _player2.text.Length >= 3 )
        {
            SceneManager.LoadScene("SampleScene");
        }
        _mainP1 = _player1.text;
        _mainP2 = _player2.text;
    }
}