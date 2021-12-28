using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodPressureMachine : MonoBehaviour
{
    float patienthight;
    string bp;
    Profile Patientprofile;
    bool knowbp;
    private void Start()
    {
        Patientprofile = Profile.profile;
    }
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(delayHightMeter(other.gameObject, 3));
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Patient"))
        {
            bp = "";
            other.GetComponent<PatientBehavior>().closedoneicon();
        }
    }
    IEnumerator delayHightMeter(GameObject patients, float time)
    {
        yield return new WaitForSeconds(time);
        if (patients.gameObject.CompareTag("Patient"))
        {
            knowbp = patients.GetComponent<Profile>().knowsbp;
            if (!knowbp)
            {
                randombp();
                patients.GetComponent<Profile>().writeBPtopatient(bp);
                patients.GetComponent<PatientBehavior>().showdoneicon();
            }
        }
    }
    void randombp()
    {
        bp = " " + Random.Range(140, 180) + " : " + Random.Range(90, 120);
    }
}
