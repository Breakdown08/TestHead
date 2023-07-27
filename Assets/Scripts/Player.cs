using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Ячейка оружия")] public GameObject cellWeapon;
    [Header("Ячейка шлема")] public GameObject cellHelmet;
    [Header("Ячейка щита")] public GameObject cellShield;

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
