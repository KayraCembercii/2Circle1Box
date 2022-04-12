using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speedP1;
    Score _score = new Score();
    int _score1;

    public int PlayerScore1
    {
        get
        {
            return _score1;
        }
        private set { }
    }
    private void FixedUpdate()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * _speedP1, Input.GetAxis("Vertical") * Time.deltaTime * _speedP1);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            _score.ScoreListMethod();
            _score1 = _score.ScoreP1;
        }
    }



}
