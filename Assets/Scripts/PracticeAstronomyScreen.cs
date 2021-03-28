using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;
using System.Collections.Generic;

public class PracticeAstronomyScreen : MonoBehaviour
{
    [SerializeField]
    private Button homeButton;

   /* [SerializeField]
    private ToggleGroup question1;
    [SerializeField]
    private ToggleGroup question2;
    [SerializeField]
    private ToggleGroup question3;
    [SerializeField]
    private ToggleGroup question4;
    [SerializeField]
    private ToggleGroup question5;*/

    [SerializeField]
    private Button selectToggleButton;
    [SerializeField]
    private TextMeshProUGUI result;

    private int value = 0;

    void Start()
    {
        homeButton.onClick.AddListener(OpenHome);
        selectToggleButton.onClick.AddListener(SelectToggle);
    }

    private void OpenHome()
    {
        Debug.Log("OpenTheory");
        GameObject.Find("DATA").GetComponent<MYPanel_controller>().changeActivePanel("MenuPanel","PracticeAstronomyLobby");
        
    }

    private void SelectToggle()
    {
        value = 0;
        MYClassQuestion[] questions = GetComponentsInChildren<MYClassQuestion>();
        for(int i=0;i<5;i++)
        {
            ToggleGroup question = questions[i].GetComponent<ToggleGroup>();
            Toggle theActiveToggle = question.ActiveToggles().FirstOrDefault();

            if(theActiveToggle != null)
            {   if(theActiveToggle.GetComponentInChildren<Text>().text == questions[i].answer)
                    value++;
            }
        }
        result.text = "Ваш результат: "+ value + " б.";
}

    public static Toggle GetActive(ToggleGroup aGroup)
    {
        return aGroup.ActiveToggles().FirstOrDefault();
    }
}
