
using UnityEngine;

public class ShipManager : MonoBehaviour
{
    Shop shopScript;

    [Header("Ships displayed in a shop")]
    public GameObject shopShip1;
    public GameObject shopShip2;
    public GameObject shopShip3;
    bool shopShip1Active;
    bool shopShip2Active;
    bool shopShip3Active;

    [Header("Ships displayed in map menu")]
    public GameObject mapShip1;
    public GameObject mapShip2;
    public GameObject mapShip3;
    bool mapShip1Active;
    bool mapShip2Active;
    bool mapShip3Active;


    private void Start()
    {
        shopScript = GetComponent<Shop>();

        shopShip1.gameObject.SetActive(false);
        shopShip2.gameObject.SetActive(false);
        shopShip3.gameObject.SetActive(false);

        mapShip1.gameObject.SetActive(false);
        mapShip2.gameObject.SetActive(false);
        mapShip3.gameObject.SetActive(false);
    }

    private void Update()
    {
        if(shopScript.currentShipNumber == 1)
        {
            shopShip1.gameObject.SetActive(true);
            shopShip2.gameObject.SetActive(false);
            shopShip3.gameObject.SetActive(false);

            mapShip1.gameObject.SetActive(true);
            mapShip2.gameObject.SetActive(false);
            mapShip3.gameObject.SetActive(false);

        }
        if (shopScript.currentShipNumber == 2)
        {
            shopShip2.gameObject.SetActive(true);
            shopShip1.gameObject.SetActive(false);
            shopShip3.gameObject.SetActive(false);

            mapShip2.gameObject.SetActive(true);
            mapShip1.gameObject.SetActive(false);
            mapShip3.gameObject.SetActive(false);
        }
        if (shopScript.currentShipNumber == 3)
        {
            shopShip3.gameObject.SetActive(true);
            shopShip1.gameObject.SetActive(false);
            shopShip2.gameObject.SetActive(false);

            mapShip3.gameObject.SetActive(true);
            mapShip1.gameObject.SetActive(false);
            mapShip2.gameObject.SetActive(false);
        }

    }

    void CheckShopShipModelsActivity()
    {
        shopShip1.gameObject.SetActive(shopShip1Active);
        shopShip2.gameObject.SetActive(shopShip2Active);
        shopShip3.gameObject.SetActive(shopShip3Active);

        mapShip1.gameObject.SetActive(mapShip1Active);
        mapShip2.gameObject.SetActive(mapShip2Active);
        mapShip3.gameObject.SetActive(mapShip3Active);
    }

    
}
