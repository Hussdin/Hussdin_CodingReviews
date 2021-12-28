using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientBehavior : MonoBehaviour
{
   public static PatientBehavior patientBehavior;
   [SerializeField]
   GameObject doneicon;
   private void Awake()
   {
        patientBehavior = this;
   }
   public void showdoneicon()
   {
     doneicon.SetActive(true);
   }
   public void closedoneicon()
   {
     doneicon.SetActive(false);
   }
   
}
