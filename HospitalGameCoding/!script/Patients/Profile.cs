using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Profile : MonoBehaviour
{
    public static Profile profile;
    public float age, weight, high;
    public string names,bp,Gender,BG,MA;
    public bool knowshigh,knowsweight,knowsbp;
    public string Disease;
    private void Awake()
    {
        profile = this;
        knowshigh = false;
        randomname();
        RandomDisease();
    }
    void randomname()
    {
        int N = Random.Range(0, 11);
        switch (N)
        {
            case 1:
                names = "aaa bbb";
                break;
            case 2:
                names = "sdd bbbgbb";
                break;
            case 3:
                names = "adcdsaa bbwdwb";
                break;
            case 4:
                names = "aayhya bbdsvvdb";
                break;
            case 5:
                names = "avdsvaa bbsdvb";
                break;
            case 6:
                names = "abewrfaa bbvcbrdb";
                break;
            case 7:
                names = "asafewfaa bvdbhmbb";
                break;
            case 8:
                names = "aunloaa bbb";
                break;
            case 9:
                names = "asafeasgaa bbbilol";
                break;
            case 10:
                names = "aefrefaa fefebbb";
                break;
        }
    }

    void RandomDisease()
    {
        int num = Random.Range(1, 3);
        switch (num)
        {
            case 1:
                Disease = "A";
                break;
            case 2:
                Disease = "B";
                break;
            case 3:
                Disease = "A";
                break;
            case 4:
                Disease = "B";
                break;
        }
    }

    public void writehightopatien(float incomehigh)
    {
        high = incomehigh;
        knowshigh = true;
    }

    public void writeweightopatient(float incomeweight)
    {
        weight = incomeweight;
        knowsweight = true;
    }

    public void writeBPtopatient(string incomebp)
    {
        bp = incomebp;
        knowsbp = true;
    }

}
