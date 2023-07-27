using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        Game.Instance.SpawnItem();
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

    public void GetItem(GameObject item, ItemType itemType)
    {
        switch (itemType)
        {
            case ItemType.Weapon:
            {
                item.transform.SetParent(cellWeapon.transform, false);
                    cellWeapon.GetComponent<Image>().enabled = false;
                break;
            }
            case ItemType.Helmet:
            {
                item.transform.SetParent(cellHelmet.transform, false);
                cellHelmet.GetComponent<Image>().enabled = false;
                break;
            }
            case ItemType.Shield:
            {
                item.transform.SetParent(cellShield.transform, false);
                cellShield.GetComponent<Image>().enabled = false;
                break;
            }
            default:
            {
                break;
            }
        }
        
    }
}
