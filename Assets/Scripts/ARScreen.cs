using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ARScreen : MonoBehaviour
{
    [SerializeField]
    private Button homeButton;

    void Start()
    {
        homeButton.onClick.AddListener(OpenHome);
        GameObject.Find("DATA").GetComponent<MYPanel_controller>().isMain = true;
    }

    private void OpenHome()
    {
        Debug.Log("OpenHome");
       // ScreenManager.isFirstLoad = false;
       FindObjectOfType<MYPanel_controller>().panels.Clear();
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

}
