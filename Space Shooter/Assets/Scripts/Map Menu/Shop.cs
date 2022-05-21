
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [Header("-----Shop sections-----")]
    [SerializeField] GameObject shipsPanel;
    [SerializeField] GameObject modulesPanel;
    [SerializeField] GameObject colorsPanel;

    [Header("-----If ship is selected, paint a preview button-----")]
    public Color ShipWindowSelectedColor;
    public GameObject Ship2BuySection;
    public GameObject Ship3BuySection;


    //-----Shop sections active-----
    bool shipsPanelActive = false;
    bool modulesPanelActive = false;
    bool colorsPanelActive = false;


    //ship buy button control----------------------
    [Header("-----Ship Select Buttons-----")]
    public GameObject shipSelect1_Button;
    public GameObject shipSelect2_Button;
    public GameObject shipSelect3_Button;
    //---------------------------------------------


    [Header("-----Unlocked ships-----")]
    public int secondShipUnlocked;
    public int thirdShipUnlocked;

    public int currentShipNumber;

    int ship2Cost = 100;
    int ship3Cost = 200;

    //references
    MoneyAndScore moneyAndScoreScript;

    private void Start()
    {
        LoadShopProgress();
        InvokeRepeating("SaveShopProgress", 1f, 1f);  //1s delay, repeat every 1s

        Debug.Log("menu started load complete");
        Debug.Log("second ship unlocked " + secondShipUnlocked);

        moneyAndScoreScript = FindObjectOfType<MoneyAndScore>().GetComponent<MoneyAndScore>();

    }

    private void Update()
    {
        ShipSelectPanelsActiveChek();

        CheckShopSectionsActivity();


    }

    //--------------top 3 buttons controlls-----------------
    public void CheckShopSectionsActivity()
    {
        shipsPanel.gameObject.SetActive(shipsPanelActive);
        modulesPanel.gameObject.SetActive(modulesPanelActive);
        colorsPanel.gameObject.SetActive(colorsPanelActive);
    }
    public void Shop_SHIPS_ButtonClick()
    {
        shipsPanelActive = true;
        modulesPanelActive = false;
        colorsPanelActive = false;
    }
    public void Shop_MODULES_ButtonClick()
    {
        shipsPanelActive = false;
        modulesPanelActive = true;
        colorsPanelActive = false;
    }
    public void Shop_COLORS_ButtonClick()
    {
        shipsPanelActive = false;
        modulesPanelActive = false;
        colorsPanelActive = true;
    }

    //--------------buy and select ship buttons controlls-----------------
    public void SHOP_Ship1_SelectButtonClick()//select 1 ship
    {
        Debug.Log("Ship 1 selected");

        currentShipNumber = 1;

        Debug.Log("current ship number - " + currentShipNumber);
    }


    public void SHOP_Ship2_BuyButtonClick() //buy second ship
    {
        if(moneyAndScoreScript.money >= ship2Cost)
        {
            moneyAndScoreScript.money -= ship2Cost; //decreasing money

            secondShipUnlocked = 1; // unlocking a second ship and saving it
            
            
            shipSelect2_Button.gameObject.SetActive(true); // turning on a select button instead of buy button

            Debug.Log("Ship 2 unlocked");
        }
    }

    public void SHOP_Ship2_SelectButtonClick() // select 2 ship
    {
        if (secondShipUnlocked == 1)
        {
            Debug.Log("Ship 2 selected");

            currentShipNumber = 2;
            
            Debug.Log("current ship number - " + currentShipNumber);
        }  
    }

    public void SHOP_Ship3_BuyButtonClick() //buy second ship
    {
        if (moneyAndScoreScript.money >= ship3Cost)
        {
            moneyAndScoreScript.money -= ship3Cost; //decreasing money

            thirdShipUnlocked = 1; // unlocking a second ship and saving it


            shipSelect3_Button.gameObject.SetActive(true); // turning on a select button instead of buy button

            Debug.Log("Ship 3 unlocked");
        }
    }

    public void SHOP_Ship3_SelectButtonClick() // select 2 ship
    {
        if (thirdShipUnlocked == 1)
        {
            Debug.Log("Ship 3 selected");

            currentShipNumber = 3;

            Debug.Log("current ship number - " + currentShipNumber);
        }
    }













    void SaveShopProgress()
    {
        PlayerPrefs.SetInt("secondShipUnlocked", secondShipUnlocked);
        PlayerPrefs.SetInt("thirdShipUnlocked", thirdShipUnlocked);

        PlayerPrefs.SetInt("currentShipNumber", currentShipNumber);

    }

    void LoadShopProgress()
    {
        secondShipUnlocked = PlayerPrefs.GetInt("secondShipUnlocked", 0);
        thirdShipUnlocked = PlayerPrefs.GetInt("thirdShipUnlocked", 0);

        currentShipNumber = PlayerPrefs.GetInt("currentShipNumber", 1);
    }

    void ResetButton() //resets all the progress
    {
        moneyAndScoreScript.money = 0;
        secondShipUnlocked = 0;
        thirdShipUnlocked = 0;
    }
















    void ShipSelectPanelsActiveChek()
    {
        if (secondShipUnlocked == 1)
        {
            shipSelect2_Button.SetActive(true);
            Ship2BuySection.GetComponent<Image>().color = ShipWindowSelectedColor;
        }
        else
        {
            shipSelect2_Button.SetActive(false);
        }

        if (thirdShipUnlocked == 1)
        {
            shipSelect3_Button.SetActive(true);
            Ship3BuySection.GetComponent<Image>().color = ShipWindowSelectedColor;
        }
        else
        {
            shipSelect3_Button.SetActive(false);
        }
    }


    public void ShipSection_Preview1()
    {

    }

    public void ShipSection_Preview2()
    {

    }

    public void ShipSection_Preview3()
    {

    }
}
