
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapButtons : MonoBehaviour
{
    [Header("Camera switch reference")]
    public Animator cameraSwitchAnimator;

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
    }

    private void Update()
    {

        topMenu.gameObject.SetActive(topMenuActive);
        optionMenu.gameObject.SetActive(optionMenuActive);
    }

    public void Map_SHOP_ButtonClick()
    {
        cameraSwitchAnimator.Play("MenuCameraSwitch_Right");
    }
    public void Shop_BACK_Button()
    {
        cameraSwitchAnimator.Play("MenuCameraSwitch_Left");
    }

    
    public void TopMenu_OpenClose_ButtonClick()
    {
        Debug.Log("pressed");

        if (topMenuOpen == false)
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
