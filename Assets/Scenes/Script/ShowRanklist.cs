using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ShowRanklist : MonoBehaviour {


    // Use this for initialization
    public int size;
    public Text[] hpText;
    public Text[] pointText ;
    public Text[] timeText ;
    public Text[] username ;

    void Start () {
        RanklistData.rd.SortList();
        int ii = 0;
        foreach (RanklistData.rankdata s in RanklistData.rd.r)
        {
            username[ii].text = s.getname();
            timeText[ii].text = Math.Round(s.gettime(),2).ToString();
            pointText[ii].text = Math.Round(s.getpoint(), 0).ToString();
            hpText[ii].text = Math.Round(s.gethp(), 0).ToString();
            ii++;
            if (ii >= size)
                break;
        }
        for(int i=ii;i< size; i++)
        {
            username[i].text = "----";
            timeText[i].text = "----";
            pointText[i].text = "----";
            hpText[i].text = "----";
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
