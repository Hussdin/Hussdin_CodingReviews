using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighMeter : MonoBehaviour
{
    float patienthigh;
    float high;
    Profile Patientprofile;
    bool knowhigh;
    private void Start()
    {
        Patientprofile = Profile.profile;
    }
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(delayHighMeter(other.gameObject, 1.5f));
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Patient"))
        {
            high = 0;
            other.GetComponent<PatientBehavior>().closedoneicon();
        }
    }
    IEnumerator delayHighMeter(GameObject patients,float time)
    {
        yield return new WaitForSeconds(time);
        if (patients.gameObject.CompareTag("Patient"))
        {
            knowhigh = patients.GetComponent<Profile>().knowshigh;
            if (!knowhigh)
            {
                randomhigh();
                patients.GetComponent<Profile>().writehightopatien(high);
                patients.GetComponent<PatientBehavior>().showdoneicon();
            }
        }
    }
    void randomhigh()
    {
        if (!knowhigh)
        {
            high = Random.Range(160, 180);
            knowhigh = true;
        }
        
    }
}
