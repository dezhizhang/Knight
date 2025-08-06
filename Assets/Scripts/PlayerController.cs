using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 玩家控制器
/// </summary>
public class PlayerController : MonoBehaviour
{
    private Vector3 _flippedScale = new Vector3(-1, 1, 1);

    // 角色移动方向
    private float _moveX;
    private float _moveY;

    // 角色移动逗度
    private float _moveSpeed = 10.0f;

    // 刚体组件
    private Rigidbody2D _rb;
    
    private void Start()
    {
        // 获取刚体组件
        _rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        Movement();
        Direction();
    }

    /// <summary>
    /// 角色移动
    /// </summary>
    private void Movement()
    {
        // 获取水平方向
        _moveX = Input.GetAxis("Horizontal");
        // 获取垂直方向
        _moveY = Input.GetAxis("Vertical");
        _rb.velocity = new Vector2(_moveX * _moveSpeed, _rb.velocity.y);
    }

    private void Direction()
    {
        if (_moveX > 0)
        {
            transform.localScale = _flippedScale;
        }
        else if (_moveX < 0)
        {
            transform.localScale = Vector3.one;
        }
    }
}