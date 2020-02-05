using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPanel : MonoBehaviour
{
    public GameObject country;
    public Text SName;
    public Text Sarea;
    public Text SVVP;
    public Text SPopul;
    bool active;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        if (active) refersh();
       
        country = GameObject.FindWithTag("Selected");
        SName.text = country.GetComponent<Country>().GetValution("Name");
        Sarea.text = "Площадь:"+country.GetComponent<Country>().GetValution("Area");
        SVVP.text = "ВВП:" + country.GetComponent<Country>().GetValution("VVP");
        SPopul.text = "Численость населения:" + country.GetComponent<Country>().GetValution("Popul");
        active = true;
    }

    public void refersh()
    {
        country.tag = "UnSelected";
        gameObject.SetActive(false);
        active=!active;
    }
}

