using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Country : MonoBehaviour
{
    public GameObject ListCountry;
    public GameObject InfoPanel;
    public GameObject Sight;
    public GameObject Point;
    public GameObject Mark;
    public string Name = "Россия";
    public int Area;
    public int VVP;
    public int Popul;
    float deltaTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.tag == "UnSelected")
        {
            Sight.SetActive(false);
            Point.SetActive(true);
            gameObject.tag = "Untagged";
        }
        if(Mark.activeSelf)
            gameObject.tag = "Marked";
    }
    public string GetValution(string value)
    {
        switch (value)
        {
           case "Name": return Name;
           case "Area": return Area.ToString();
           case "VVP": return VVP.ToString();
           case "Popul": return Popul.ToString();
            default:
                return "";
                
        }
        
    }
    private void OnMouseUp()
    {
        if ((deltaTime < 2f) && (!Mark.activeSelf))
        {
            Debug.Log("PointSelect");
            if (InfoPanel.activeSelf)
            {
                Sight.SetActive(false);
                Point.SetActive(true);
                InfoPanel.GetComponent<ControlPanel>().refersh();
            }
            else
            {
                Sight.SetActive(true);
                gameObject.tag = "Selected";
                InfoPanel.SetActive(true);
                Point.SetActive(false);
            }
            deltaTime = 0f;
        }
     
        if (gameObject.tag!="Marked")
        {
            if (deltaTime > 2f)
            {
                Debug.Log("MArkON");
                if (Point.activeSelf)
                    Point.SetActive(false);
                Mark.SetActive(true);
                if (!Sight.activeSelf)
                    Sight.SetActive(true);
                if (InfoPanel.activeSelf)
                    InfoPanel.GetComponent<ControlPanel>().refersh();
                gameObject.tag = "Marked";
               


            }
        }
        else
        {
            Debug.Log("MArkOff");
            Mark.SetActive(false);
            Sight.SetActive(false);
            gameObject.tag = "UnSelected";
        }
        deltaTime = 0f;
    }
   

    private void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {

            deltaTime += Input.GetTouch(0).deltaTime;
          

        }
        else
            deltaTime = 0;
    }
}
