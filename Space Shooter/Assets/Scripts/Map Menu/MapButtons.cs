using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapButtons : MonoBehaviour
{
    [Header("Two switchblade windows")]
    public GameObject mainPart;
    public GameObject shopWindow;
    bool mainPartActive;
    bool shopWindowActive;

    private void Start()
    {
        mainPartActive = true;
        shopWindowActive = false; 
    }

    private void Update()
    {
        mainPart.gameObject.SetActive(mainPartActive);
        shopWindow.gameObject.SetActive(shopWindowActive);
    }

    public void Map_SHOP_ButtonClick()
    {
        mainPartActive = !mainPartActive;
        shopWindowActive = !shopWindowActive;
    }

    public void Shop_BACK_Button()
    {
        mainPartActive = !mainPartActive;
        shopWindowActive = !shopWindowActive;
    }

  





}
