using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Rigidbody2D _rg;
    [SerializeField] private float _boxSpeed;

    private void Awake()
    {
        _rg = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Down":
                _rg.gravityScale = 0;
                _rg.velocity = Vector2.up * _boxSpeed;
                break;
            case "Up":
                _rg.gravityScale = 1;
                break;
            case "Player":
                Destroy(this.gameObject);
                break;
            case "Player1":
                Destroy(this.gameObject);
                break;
        }
    }

}
