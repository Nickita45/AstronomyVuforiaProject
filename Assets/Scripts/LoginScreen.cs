using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoginScreen : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField login;
    [SerializeField]
    private TMP_InputField password;
    [SerializeField]
    private Button enterButton;
    [SerializeField]
    private Button registrarionButton;

    private void Awake()
    {
        if (!ScreenManager.isFirstLoad)
        {
             GameObject.Find("DATA").GetComponent<MYPanel_controller>().changeActivePanel("MenuPanel", "LoginPanel");
            //ScreenManager.TransitScreen("MenuPanel", "LoginPanel");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        enterButton.onClick.AddListener(TryEnter);
        registrarionButton.onClick.AddListener(OpenRegistrationScreen);
    }

    private void TryEnter()
    {
        string tempLogin = PlayerPrefs.GetString("login");
        string tempPassword = PlayerPrefs.GetString("password");

        if (login.text == "" || password.text == "")
        {

        }
        else
        {
            if (tempLogin == login.text && tempPassword == password.text)
            {
                //ScreenManager.TransitScreen("MenuPanel", "LoginPanel");
                GameObject.Find("DATA").GetComponent<MYPanel_controller>().changeActivePanel("MenuPanel", "LoginPanel");
            }
            else
            {
                //MYPanel_controller.changeActivePanel(2,0);
                OpenRegistrationScreen();
            }
        }


    }

    private void OpenRegistrationScreen()
    {
        GameObject.Find("DATA").GetComponent<MYPanel_controller>().changeActivePanel("RegistrationPanel", "LoginPanel");
        //ScreenManager.TransitScreen("RegistrationPanel", "LoginPanel");
    }
}
