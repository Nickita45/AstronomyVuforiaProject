using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MYPanel_controller : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> panels = new List<GameObject>(); 
    public GameObject canvas;
    public int catalog_page_practice = 0;
    /*public GameObject MenuPanel;
    public GameObject LoginPanel;
    public GameObject TheoryPanel;
    //! 
    public GameObject SunSytem;
    public GameObject Mecrury,EarthPanel;*/
    //!
    public void setCatalog(int catalog)
    {
        catalog_page_practice=catalog;
    }
    
    void Start(){
        if(panels.Count == 0)
        foreach(Transform child in canvas.transform)
            panels.Add(child.gameObject);
        print(panels.Count);
    }

    
    public void changeActivePanel(string open,string close)
    {
        //print(panels[0].name);
        panels.Find(item => item.name == open).SetActive(true);
        panels.Find(item => item.name == close).SetActive(false);
    }
}
