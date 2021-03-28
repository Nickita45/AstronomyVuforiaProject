using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MYClassQuestion : MonoBehaviour
{
   public string name_question = "";
   public string[] variants = new string[4];
   public string answer = "";
   public MYClassQuestion(string name_question, string[] variants, string answer)
   {
       this.name_question=name_question;
       this.variants=variants;
       this.answer=answer;
   }
   public void setClass(MYClassQuestion question){
       this.name_question=question.name_question;
       this.variants=question.variants;
       this.answer=question.answer;
   }

}
