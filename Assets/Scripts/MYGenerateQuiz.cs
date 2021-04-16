using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MYGenerateQuiz : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public int count_question = 5;
    public TextMeshProUGUI text_name;
    MYClassQuestion[] questions = { new MYClassQuestion("Сколько планет в солнечной системе?", new string[]{"5 планет","8 планет","7 планет","1 планета"},"8 планет")
    , new MYClassQuestion("Какая планета находится ближе всех к солнцу?", new string[]{"Венера","Меркурий","Уран","Земля"},"Меркурий")
    , new MYClassQuestion("На какой планете живут люди?", new string[]{"Земля","Венера","Марс","Сатурн"},"Земля")
    , new MYClassQuestion("Какая планета движется вокруг солнца быстрее всех?", new string[]{"Юпитер","Земля","Меркурий","Солнце"},"Меркурий")
    ,new MYClassQuestion("Какая планета самая большая?", new string[]{"Солнце","Юпитер","Венера","Уран"},"Юпитер") 
    };

    MYClassQuestion[] questions_mercury = { new MYClassQuestion("Планета Меркурий названа в честь:", new string[]{"древнегреческого бога земледелия","древнеримского бога торговли","в честь астронома, открывшего его","другой вариант"},"древнеримского бога торговли")
    , new MYClassQuestion("Название космического аппарата NASA, запущенного 3 ноября 1973 года для изучения Меркурия:", new string[]{"Маринер-10","Вояджер-1","Вояджер-2","Новые горизонты"},"Маринер-10")
    , new MYClassQuestion("Период полного обращения Меркурия вокруг Солнца составляет:", new string[]{"57 Земных суток","88 Земных суток","156 Земных суток","975 Земны суток"},"88 Земных суток")
    , new MYClassQuestion("Сколько спутников у Меркурия?", new string[]{"2","3","1","Ни одного"},"Ни одного")
    ,new MYClassQuestion("Меркурий относится:", new string[]{"к планетам земной группы","к газовым гигантам","к поясу астероидов","к карликовым планетам"},"к планетам земной группы") 
    ,new MYClassQuestion("По одной из гипотез Меркурий в прошлом являлся:", new string[]{"спутником Венеры","спутником Марса","спутником Плутона","блуждающей планетой в Солнечной системе"},"спутником Венеры") 
    };
    MYClassQuestion[] questions_earth = { new MYClassQuestion("Земля бывает ближе всего к Солнцу", new string[]{"В начале января","В начале июля","В конце мая","В конце октября"},"В начале января")
    , new MYClassQuestion("Какой средний радиус Земли?", new string[]{"8540 километров","6371 километров","19032 километра","13279 километра"},"6371 километров")
    , new MYClassQuestion("Какая по счету планета Земля от Солнца?", new string[]{"1","3","2","8"},"3")
    , new MYClassQuestion("По мнению ученых Земля образовалась", new string[]{"14 миллиардов лет назад","4,5 миллиарда лет назад","600 миллионов лет назад","50 миллионов лет назад"},"4,5 миллиарда лет назад")
    ,new MYClassQuestion("Расстояние от Земли до Луны составляет", new string[]{"~1,5 миллиона километров","~384 тысячи километров","~871 тысяча километров","~1037 тысяча километров"},"~384 тысячи километров") 
    ,new MYClassQuestion("Первым человеком, увидевшим Землю из космоса был:", new string[]{"Валентина Терешкова","Юрий Гагарин","Скот Келли","Нил Армстронг"},"Юрий Гагарин") 
    };
    MYClassQuestion[] questions_star_evolution = { new MYClassQuestion("Что является результатом первого этапа формирования звезд?", new string[]{"Нейтронная звезда","Красный гигант","Протозвезда","Белый карлик"},"Протозвезда")
    , new MYClassQuestion("Самыми долгоживущими звездами являются?", new string[]{"Звезды гиганты","Звезды карлики","Звезды типа Солнца","Сверхгиганты"},"Звезды карлики")
    , new MYClassQuestion("Какая следующая стадия эволюции нашего Солнца?", new string[]{"Черная дыра","Красный карлик","Красный гигант","Нейтронная звезда"},"Красный гигант")
    , new MYClassQuestion("На конечной стадии своей эволюции Солнце превратится в ...?", new string[]{"Белого карлика","Красного гиганта","Нейтронную звезду","Черную дыру"},"Белого карлика")
    , new MYClassQuestion("Сверхплотная звезда, которая сформировалась в результате взрыва Сверхновой и состоящая из нейтронной сердцевины, это...", new string[]{"Белый карлик","Черная дыра","Красный гигант","Нейтронная звезда"},"Нейтронная звезда") 
    };
    void Start(){
        //addContent();
    } 
    public void changeNameTopic(int id)
    {
        switch(id)
        {
            case 0:
                text_name.text = "Солнечная система";
                break;
            case 1:
                text_name.text = "Меркурий";
                break;
            case 2:
                text_name.text = "Земля";
                break;
            case 3:
                text_name.text = "Эволюция звезд";
                break;
        }
    }
    public void addContent()
    {
        GameObject newObj;
        List<MYClassQuestion[]> question_lists = new List<MYClassQuestion[]>();
        question_lists.Add(questions);
        question_lists.Add(questions_mercury);
        question_lists.Add(questions_earth);
        question_lists.Add(questions_star_evolution);
        int page = GameObject.Find("DATA").GetComponent<MYPanel_controller>().catalog_page_practice;
        changeNameTopic(page);
        //List<SkinnedMeshRenderer> meshes = player.GetComponent<CharacterModel>().componentsCharacter;
        //countElements = meshes.Count;
        //print(countElements);
        int[] random_arr = new int[count_question];
        for(int i=0;i<random_arr.Length;i++)
            random_arr[i]=i;
        Shuffle(random_arr);
        
        for(int i=0;i<count_question;i++)
        {
            newObj = Instantiate(prefab,transform);
            //newObj.GetComponentInChildren<MeshFilter>().mesh = meshes[i].sharedMesh; 
            newObj.name = "Question" + (i+1); 
            print(random_arr[i]);
            newObj.GetComponentInChildren<MYClassQuestion>().setClass(question_lists[page][random_arr[i]]);
            newObj.GetComponentsInChildren<TextMeshProUGUI>()[0].text = (i+1)+"."+question_lists[page][random_arr[i]].name_question;
            for(int j=0;j<4;j++)
            {
                newObj.GetComponentsInChildren<Text>()[j].text = question_lists[page][random_arr[i]].variants[j];
            }
            GameObject gmj = newObj;
            //newObj.GetComponentInChildren<Button>().onClick.AddListener(() => onClickByCategories(gmj));

        }
    }
    public void deleteComponents(GameObject gmj)
    {
        
        for(int i=gmj.transform.childCount-1;i>=0;i--)
        {
            if(gmj.transform.GetChild(i).name != "Button")
            Destroy(gmj.transform.GetChild(i).gameObject);
        }
    }
    public void Shuffle(int[] arr)
    {
    // создаем экземпляр класса Random для генерирования случайных чисел
    Random rand = new Random();
 
    for (int i = arr.Length - 1; i >= 1; i--)
    {
        int j = Random.Range(0,i + 1);
 
        int tmp = arr[j];
        arr[j] = arr[i];
        arr[i] = tmp;
    }
    }

}
