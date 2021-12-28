using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingScript : MonoBehaviour
{
    [SerializeField]
    GameObject ProfilePanel;
    bool opened,dbopened;
    private void Awake()
    {
        opened = false;
    }
    public void onclickProfilPanel()
    {
        if (!opened)
        {
            ProfilePanel.SetActive(true);
            opened = true;
        }
        else
        {
            ProfilePanel.SetActive(false);
            opened = false;
        }
        
    }
    public void onclickDBBtn()
    {
        if (!dbopened)
        {
            ProfilePanel.SetActive(true);
            dbopened = true;
        }
        else
        {
            ProfilePanel.SetActive(false);
            dbopened = false;
        }
    }
}
