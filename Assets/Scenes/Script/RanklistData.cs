using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RanklistData : MonoBehaviour {

    public static RanklistData rd;
    public class rankdata
    {
        string username;
        double ftime;
        double point;
        double hp;
        public rankdata(string s,double d,double p,double _hp)
        {
            username = s;
            ftime = d;
            point = p;
            hp = _hp;
        }
        public string getname()
        {
            return username;
        }

        public double gettime()
        {
            return ftime;
        }

        public double gethp()
        {
            return hp;
        }

        public double getpoint()
        {
            return point;
        }

    }
    public List<rankdata> r = new List<rankdata>();

    private int SortListCompare(rankdata a, rankdata b)
    {
        if(a.gethp() > b.gethp())
        {
            return -1;
        }
        else if (a.gethp() < b.gethp())
        {
            return 1;
        }
        else if (a.getpoint() > b.getpoint())
        {
            return -1;
        }
        else if (a.getpoint() < b.getpoint())
        {
            return 1;
        }

        else if (a.gettime() < b.gettime())
        {
            return -1;
        }
        else if (a.gettime() > b.gettime())
        {
            return 1;
        }
        return 0;
    }

    public void SortList()
    {
        r.Sort(SortListCompare);
    }

    private void Awake()
    {
        if (rd == null)
        {
            DontDestroyOnLoad(gameObject);
            rd = this;
        }
        else if (rd != null)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
