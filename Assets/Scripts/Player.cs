using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = transform.GetComponent<Animator>();
    }

    private void InitFarm()
    {
        Debug.Log("ASDSDAASDDAADS");
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
