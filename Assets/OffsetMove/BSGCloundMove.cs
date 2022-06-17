// * ============================================================= *
// * 描 述：
// * 作 者：
// * 版 本：v 1.0
// * 创建时间：2018/12/04 11:09:45
// * ============================================================= *
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 云移动
/// </summary>
[AddComponentMenu("BSGTool/BSGCloundMove")]
public class BSGCloundMove : MonoBehaviour
{
    public float _MoveMinX = -100;
    public float _MoveMaxX = 100;
    public float _MinSpeed = 0.1f;
    public float _MaxSpeed = 0.5f;

    public float m_Speed;
    private Transform m_Transform;

    public delegate void CloudMoveHandler();
    public event CloudMoveHandler ClodMoveEvent;

    public bool playing = true;
    public bool userControlSpeed = false;

    public enum Direction
    {
        Right,
        Left,
        Top,
        Down,
    }
    public Direction _Direction;

    void Start()
    {
        m_Speed = Random.Range(_MinSpeed, _MaxSpeed);
        m_Transform = transform;
        switch (_Direction)
        {
            case Direction.Right:
                ClodMoveEvent += MoveRight;
                break;
            case Direction.Left:
                ClodMoveEvent += MoveLeft;
                break;
            case Direction.Top:
                ClodMoveEvent += MoveTop;
                break;
            case Direction.Down:
                ClodMoveEvent += MoveDown;
                break;
            default:
                break;
        }
    }

    void Update()
    {
        ClodMoveEvent();
    }
    private void MoveLeft()
    {
        if (playing)
        {
            m_Transform.Translate(Vector3.left * Time.deltaTime * m_Speed);
            if (m_Transform.localPosition.x < _MoveMinX)
            {
                m_Transform.localPosition = new Vector3(_MoveMaxX, m_Transform.localPosition.y);
                if (!userControlSpeed)
                {
                    m_Speed = Random.Range(_MinSpeed, _MaxSpeed);
                }

            }
        }

    }
    private void MoveRight()
    {
        if (playing)
        {
            m_Transform.Translate(Vector3.right * Time.deltaTime * m_Speed);
            if (m_Transform.localPosition.x > _MoveMaxX)
            {
                m_Transform.localPosition = new Vector3(_MoveMinX, m_Transform.localPosition.y);
                if (!userControlSpeed)
                {
                    m_Speed = Random.Range(_MinSpeed, _MaxSpeed);
                }
            }
        }
    }
    private void MoveTop()
    {
        if (playing)
        {
            m_Transform.Translate(Vector3.up * Time.deltaTime * m_Speed);
            if (m_Transform.localPosition.y > _MoveMinX)
            {
                m_Transform.localPosition = new Vector3(m_Transform.localPosition.x, _MoveMaxX);
                if (!userControlSpeed)
                {
                    m_Speed = Random.Range(_MinSpeed, _MaxSpeed);
                }

            }
        }

    }
    private void MoveDown()
    {
        if (playing)
        {
            m_Transform.Translate(Vector3.down * Time.deltaTime * m_Speed);
            if (m_Transform.localPosition.y < _MoveMinX)  
            {
                m_Transform.localPosition = new Vector3(m_Transform.localPosition.x, _MoveMaxX);
                if (!userControlSpeed)
                {
                    m_Speed = Random.Range(_MinSpeed, _MaxSpeed);
                }

            }
        }

    }
}
