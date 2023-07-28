using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject cellWeapon;
    public GameObject cellHelmet;
    public GameObject cellShield;
    public GameObject bag;

    private Animator animator;
    void Start()
    {
        animator = transform.GetComponent<Animator>();
    }

    IEnumerator OpenChest(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Interface.Instance.ActivatePopup();
        Game.Instance.SpawnItem();
    }

    private void InitFarm()
    {
        animator.Play("HeroKnight_Attack1");
        StartCoroutine(OpenChest(0.3f));
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

    public void GetItem(ItemType itemType)
    {
        switch (itemType)
        {
            case ItemType.Weapon:
            {
                cellWeapon.GetComponent<Image>().sprite = Game.Instance.GetCurrentItem(itemType).GetComponent<Image>().sprite;
                cellWeapon.GetComponent<Image>().color = new Color(255, 255, 255);
                break;
            }
            case ItemType.Helmet:
            {
                cellHelmet.GetComponent<Image>().sprite = Game.Instance.GetCurrentItem(itemType).GetComponent<Image>().sprite;
                cellHelmet.GetComponent<Image>().color = new Color(255, 255, 255);
                break;
            }
            case ItemType.Shield:
            {
                cellShield.GetComponent<Image>().sprite = Game.Instance.GetCurrentItem(itemType).GetComponent<Image>().sprite;
                cellShield.GetComponent<Image>().color = new Color(255, 255, 255);
                break;
            }
            default:
            {
                break;
            }
        }
    }

    void OnMouseDown()
    {
        InitFarm();
    }
}
