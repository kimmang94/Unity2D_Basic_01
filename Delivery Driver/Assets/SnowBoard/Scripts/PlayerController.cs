using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigid2d = null;

    [SerializeField] private float torqueAmount = 1f;
    [SerializeField] private float boostSpeed = 100f;
    [SerializeField] private float baseSpeed = 15f;
    private SurfaceEffector2D surfaceEffector2D = null;
    
    private void Start()
    { 
         rigid2d = GetComponent<Rigidbody2D>();
         surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }


    private void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    /// <summary>
    /// 플레이어 회전에 관한 함수 (좌 우 방향키를 클릭해 해당 방향으로 회전)
    /// </summary>
    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigid2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigid2d.AddTorque(-torqueAmount);
        }
    }

    /// <summary>
    /// 플레이어 부스터 에 관한함수 (위 방향키를 누를경우 부스터 사용)
    /// </summary>
    private void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }
}
