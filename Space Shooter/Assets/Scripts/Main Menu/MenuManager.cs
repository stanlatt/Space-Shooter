using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    public GameObject mainButtonMenu;
    public GameObject mainOptionsMenu;

    bool mainMenuActive;
    bool optionMenuActive;

    //dark screen animator controller
    Animator darkScreenAnimator;

    private void Start()
    {
        mainMenuActive = true;  //turning the main menu on
        optionMenuActive = false;  //turning the option menu off 

        darkScreenAnimator = GameObject.Find("Canvas for dark screen").GetComponent<Animator>();
        darkScreenAnimator.Play("HideDark");
    }

    private void Update()
    {
        mainButtonMenu.gameObject.SetActive(mainMenuActive);
        mainOptionsMenu.gameObject.SetActive(optionMenuActive);
    }

    //main menu PLAY button click
    public void MainMenuPLAYButtonClick()
    {
        darkScreenAnimator.Play("ShowDark");
        SceneManager.LoadScene(1);
    }

    //main menu OPTIONS button click
    public void MainMenuOptionButtonClick()
    {
        mainMenuActive = !mainMenuActive;  //turning the main menu off
        optionMenuActive = !optionMenuActive;  //turning the option menu on
    }

    //main menu EXIT button click
    public void ExitButtonClick()
    {
        Application.Quit();
    }

    //option menu BACK button click
    public void OptionsMenuBackClick()
    {
        mainMenuActive = !mainMenuActive;  //turning the main menu on
        optionMenuActive = !optionMenuActive;  //turning the option menu off
    }



}