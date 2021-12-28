using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviorControll : MonoBehaviour
{
    public static PlayerBehaviorControll player;
    bool withpatient;
    Vector3 Distance;
    public GameObject Patients;
    ProfileManager Patientprofile;
    Vector3 patientsrotate;

    private void Awake()
    {
        withpatient = false;
        Distance = new Vector3(0, 0, 2);
    }

    private void Update()
    {
        if (withpatient)
        {
            PatientFollow(Patient(Patients));
            if (Input.GetKey(KeyCode.F))
            {
                withpatient = false;
                Patients = null;
            }
        }
        
    }
   public GameObject Patient(GameObject patient)
    {
        Patients = patient;
        //patientsrotate = GetComponent<Playercontroller>().desirero;
        return Patients;
    }

    void PatientFollow(GameObject patient)
    {
        patient.transform.position = Vector3.MoveTowards(patient.transform.position, GameObject.Find("Player").transform.position + Distance, 20f);
        patient.transform.rotation = this.transform.rotation;
        //patient.transform.Rotate(patientsrotate);
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Patient"))
        {
            if (!withpatient)
            {
                if (Input.GetKey("space"))
                {
                    Patient(collision.gameObject);
                    withpatient = true;
                }
            }
        }
    }
    
    

}
