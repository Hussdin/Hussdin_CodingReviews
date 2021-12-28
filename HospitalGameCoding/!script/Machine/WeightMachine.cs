using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightMachine : MonoBehaviour
{
    float patienthight;
    float weight;
    Profile Patientprofile;
    bool knowweight;
    private void Start()
    {
        Patientprofile = Profile.profile;
    }
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(delayHightMeter(other.gameObject, 1.5f));
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Patient"))
        {
            weight = 0;
            other.GetComponent<PatientBehavior>().closedoneicon();
        }
    }
    IEnumerator delayHightMeter(GameObject patients, float time)
    {
        yield return new WaitForSeconds(time);
        if (patients.gameObject.CompareTag("Patient"))
        {
            knowweight = patients.GetComponent<Profile>().knowsweight;
            if (!knowweight)
            {
                randomweight();
                patients.GetComponent<Profile>().writeweightopatient(weight);
                patients.GetComponent<PatientBehavior>().showdoneicon();
            }
        }
    }
    void randomweight()
    {
        if (!knowweight)
        {
            weight = Random.Range(47, 70);
            knowweight = true;
        }

    }
}
