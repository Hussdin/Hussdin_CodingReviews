using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiscussionTable : MonoBehaviour
{
    DiseaseInformation information;

    [SerializeField]
    GameObject DiscussionPanel;
    [SerializeField]
    Text Symtomtxtbox;

    string desease;
    int amount;

    bool patient, player;

    private void Start()
    {
        information = DiseaseInformation.infomation;
        amount = 0;
        patient = false;
        player = false;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Patient"))
        {
            patient = true;
        }
        if (other.gameObject.CompareTag("Player"))
        {
            player = true;
        }
        if(patient && player)
        {
            DiscussionPanel.SetActive(true);
            getsymtoms(information.amount);
            patient = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Patient"))
        {
            amount = 0;
        }
    }

    void getsymtoms(int amount)
    {
        if (amount == 3)
        {
            Symtomtxtbox.text = "aaaaa " + information.symtomss[0] + " aaaaaaa " + information.symtomss[1] + " aaaaaaa " + information.symtomss[2];
        }
        else
        {
            Symtomtxtbox.text = "aaaaa " + information.symtomss[0] + " aaaaaaa " + information.symtomss[1];
        }
    }   
}
