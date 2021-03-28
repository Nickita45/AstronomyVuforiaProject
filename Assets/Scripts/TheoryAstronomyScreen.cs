using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TheoryAstronomyScreen : MonoBehaviour
{
    [SerializeField]
    private Button homeButton;
    [SerializeField]
    private Button ARButton;

    // Start is called before the first frame update
    void Start()
    {
        homeButton.onClick.AddListener(OpenHome);
        ARButton.onClick.AddListener(OpenAR);
        print("AA");
    }

    private void OpenHome()
    {
        Debug.Log("OpenTheory");
        GameObject.Find("DATA").GetComponent<MYPanel_controller>().changeActivePanel("MenuPanel", "TheoryAstronomyScreen");
        //MYPanel_controller.changeActivePanel(1,4);
        //ScreenManager.TransitScreen("MenuPanel", "TheoryAstronomyScreen");
    }

    public void OpenAR()
    {
        Debug.Log("OpenAR");
        SceneManager.LoadScene("ARAstronomy", LoadSceneMode.Single);
    }
    public void OpenSunSystem()
    {
        GameObject.Find("DATA").GetComponent<MYPanel_controller>().changeActivePanel("TheorySunSystemScreen","TheoryAstronomyScreen");
    }

}
