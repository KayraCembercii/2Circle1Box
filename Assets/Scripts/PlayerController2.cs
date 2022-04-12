using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    [SerializeField] float _speedP2;
    Score _score = new Score();
    int _score2;
    private void FixedUpdate()
    {
        transform.position += new Vector3 (Input.GetAxis("Horizontal2") * _speedP2 * Time.deltaTime, Input.GetAxis("Vertical2") * _speedP2 * Time.deltaTime);
    }

    public int PlayerScore2
    {
        get
        {
            return _score2;
        }
        private set { }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            _score.ScoreArrayMethod();
            _score2 = _score.ScoreP2; 
        }
    }
}
