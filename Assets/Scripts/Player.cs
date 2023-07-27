using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("������ ������")] public GameObject cellWeapon;
    [Header("������ �����")] public GameObject cellHelmet;
    [Header("������ ����")] public GameObject cellShield;

    private Animator animator;
    void Start()
    {
        animator = transform.GetComponent<Animator>();
    }

    private void InitFarm()
    {
        animator.Play("HeroKnight_Attack1");
    }

    private void ListenInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InitFarm();
        }
    }

    private void Update()
    {
        ListenInput();
    }
}
