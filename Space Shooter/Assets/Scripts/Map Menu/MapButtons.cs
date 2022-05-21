
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapButtons : MonoBehaviour
{
    [Header("Two switchblade windows: mapMenu and shop")]
    public GameObject mainPart;
    public GameObject shopWindow;
    bool mainPartActive;
    bool shopWindowActive;

    [Header("TopMenu references")]
    public Animator openCloseAnimator;
    public bool topMenuOpen;

    public GameObject topMenu;
    bool topMenuActive;
    public GameObject optionMenu;
    bool optionMenuActive;



    private void Start()
    {
        topMenuActive = true;
        topMenuOpen = false;
        optionMenuActive = false;

        mainPartActive = true;
        shopWindowActive = false; 
    }

    private void Update()
    {
        mainPart.gameObject.SetActive(mainPartActive);
        shopWindow.gameObject.SetActive(shopWindowActive);

        topMenu.gameObject.SetActive(topMenuActive);
        optionMenu.gameObject.SetActive(optionMenuActive);
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

    
    public void TopMenu_OpenClose_ButtonClick()
    {
        if(topMenuOpen == false)
        {
            openCloseAnimator.Play("Open");
            topMenuOpen = true;
        }
        else
        {
            openCloseAnimator.Play("Close");
            topMenuOpen = false;
        }

        
    }

    public void TopMenu_Options_ButtonClick()
    {
        optionMenuActive = !optionMenuActive;
        topMenuActive = !topMenuActive;
    }

    public void TopMenu_OptionsBack_ButtonClick()
    {
        optionMenuActive = !optionMenuActive;
        topMenuActive = !topMenuActive;
    }

    public void TopMenu_Back_ButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
