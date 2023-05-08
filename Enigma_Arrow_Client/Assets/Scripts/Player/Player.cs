using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _hp;
    public int HP
    {
        get
        {
            return _hp;
        }
        set
        {
            _hp= value;

            if(_hp <= 0)
            {
                GameOver();
            }
        }
    }

    public const int MaxHP = 100;

    public HPBar _hpBar;

    private void Start()
    {
        HP = MaxHP;
        _hpBar.SetMaxHP(MaxHP);
    }

    private void Update()
    {
        _hpBar.SetHP(HP);
    }

    public void Hit(int damage)
    {
        HP -= damage;  
        
    }


    private void GameOver()
    {
        Debug.Log("죽음");
        // 본인 인지 아닌지 처리 매개변수 넣기
        //GameManager.Instance.GameOver();
    }
}
