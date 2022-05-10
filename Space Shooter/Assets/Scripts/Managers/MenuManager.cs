
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    public GameObject mainButtonMenu;
    public GameObject mainOptionsMenu;

    bool mainMenuActive;
    bool optionMenuActive;

    private void Start()
    {
        mainMenuActive = true;  //turning the main menu on
        optionMenuActive = false;  //turning the option menu off 
    }

    private void Update()
    {
        mainButtonMenu.gameObject.SetActive(mainMenuActive);
        mainOptionsMenu.gameObject.SetActive(optionMenuActive);
    }

    //main menu CONTINUE button click
    public void MainMenuContinueButtonClick()
    {
        SceneManager.LoadScene(1);
    }

    //main menu NEW GAME button click
    public void MainMenuNewGameButtonClick()
    {
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
