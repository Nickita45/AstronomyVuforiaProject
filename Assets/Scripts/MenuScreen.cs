using UnityEngine;
using UnityEngine.UI;

public class MenuScreen : MonoBehaviour
{
    [SerializeField]
    private Button theoryButton;
    [SerializeField]
    private Button practiceButton;
    [SerializeField]
    private Button exitButton;
    // Start is called before the first frame update
    void Start()
    {
        theoryButton.onClick.AddListener(OpenTheory);
        practiceButton.onClick.AddListener(OpenPractice);
        exitButton.onClick.AddListener(closeApp);
    }
    private void closeApp()
    {
        Application.Quit();
    }
    private void OpenTheory()
    {
        Debug.Log("OpenTheory");
        GameObject.Find("DATA").GetComponent<MYPanel_controller>().changeActivePanel("TheoryAstronomyScreen", "MenuPanel");
        //ScreenManager.TransitScreen("TheoryAstronomyScreen", "MenuPanel");
    }

    private void OpenPractice()
    {
        Debug.Log("OpenPractice");
        GameObject.Find("DATA").GetComponent<MYPanel_controller>().changeActivePanel("PracticeAstronomyLobby", "MenuPanel");
        //ScreenManager.TransitScreen("PracticeAstronomyScreen", "MenuPanel");
    }

}
