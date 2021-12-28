using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileManager : MonoBehaviour
{
    [SerializeField]
    Text Names, Gender, Age, High, Weight, BG, BP, MA;

    Profile patientprofile;

    public GameObject patient;
    private void Awake()
    {
        patient = null;
    }
    private void OnEnable()
    {
        patient = GameObject.Find("Player").GetComponent<PlayerBehaviorControll>().Patients;
        if (patient == null)
        {
            Names.text = "Name : No Patient";
            Gender.text = "Gender :";
            Age.text = "Age :";
            High.text = "High :";
            Weight.text = "Weight :";
            BG.text = "Blood Group : ";
            BP.text = "Blood Pressure :";
            MA.text = "N/A";

        }

        else if(patient != null)
        {
            patientprofile = patient.GetComponent<Profile>();

            Names.text = "Name : " + patientprofile.name;
            Gender.text = "Gender :" + patientprofile.Gender; ;
            Age.text = "Age :" + patientprofile.age;
            High.text = "High :" + patientprofile.high;
            Weight.text = "Weight :" +patientprofile.weight;
            BG.text = "Blood Group : "+patientprofile.BG;
            BP.text = "Blood Pressure :"+patientprofile.bp;
            MA.text = "N/A"+patientprofile.MA;
        }
    }


}
