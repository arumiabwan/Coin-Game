using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PushedTitleButton : MonoBehaviour {

    public GameObject DefaultUI;
    public GameObject RuleUI;
    public GameObject RecordUI;
    public GameObject StartUI;

    public void DefaultDisplay()
    {

        DefaultUI.SetActive(true);

    }

    public void RuleDisplay()
    {

        RuleUI.SetActive(true);

    }

    public void RecordDisplay()
    {

        RecordUI.SetActive(true);

    }

    public void DefaultDisplayout()
    {

        DefaultUI.SetActive(false);
        
        RuleUI.SetActive(false);
        RecordUI.SetActive(false);

    }

    public void StartDisplay()
    {

        StartUI.SetActive(true);

    }



}
