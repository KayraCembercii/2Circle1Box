using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    int _result;
    [SerializeField] GameObject _endGamePanel;
    [SerializeField] Text _p1Text, _p2Text,_p1EndText, _p2EndText,_timerText;
    [SerializeField] PlayerController _p1;
    [SerializeField] PlayerController2 _p2; 

    private void Update()
    {
        _p1Text.text = LoginControl._mainP1 + ": " + _p1.PlayerScore1;
        _p2Text.text = LoginControl._mainP2 + ": " + _p2.PlayerScore2;
        EndGame();
    }
    void EndGame()
    {
        _result = _p1.PlayerScore1 + _p2.PlayerScore2;
        if (_result == 11)
        {
            _endGamePanel.SetActive(true);
            _p1EndText.text = _p1Text.text;
            _p2EndText.text = _p2Text.text;
        }
        else
        {
            _endGamePanel.SetActive(false);
        }
    }

     public void RestartButton()
    {
        _result = 0;
        StartCoroutine(Restart());
    }

    IEnumerator Restart()
    {
        _timerText.color = Color.red;
        _timerText.text = "3";
       yield return new WaitForSeconds(1);
        _timerText.color = Color.yellow;
        _timerText.text = "2";
        yield return new WaitForSeconds(1);
        _timerText.color = Color.green;
        _timerText.text = "1";
        yield return new WaitForSeconds(1);
        _endGamePanel.SetActive(false);
        SceneManager.LoadScene("LoginScene");
        _endGamePanel.SetActive(false);

    }
   

}