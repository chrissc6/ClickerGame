using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleTut : MonoBehaviour
{
    public Text cashText;
    public double cash;
    public double cashClickValue;

    public Text cashPerSecText;
    public double cashPerSec;

    public Text workUpgradeText;
    public double workUpgradeCost;
    public double workUpgradeLevel;

    public Text biz1Text;
    public double biz1Cost;
    public double biz1UpgradeLevel;

    public void Start()
    {
        cashClickValue = 1;
        workUpgradeCost = 10;
        biz1Cost = 25;
        biz1UpgradeLevel = 1;
        workUpgradeLevel = 1;
    }

    public void Update()
    {
        //cashPerSec = biz1UpgradeLevel;

        cashText.text = "Cash: $" + cash.ToString("F0");
        cashPerSecText.text = "Cash Per Sec: $" + cashPerSec.ToString("F0");
        workUpgradeText.text = "Upgrade: $" + workUpgradeCost.ToString("F0") + " \nROI: +$" + workUpgradeLevel + "per click";
        biz1Text.text = "Lemonade Stand $" + biz1Cost.ToString("F0") + " \nROI: +$" + biz1UpgradeLevel + " cash /sec";

        cash += cashPerSec * Time.deltaTime;
    }

    public void Work()
    {
        cash += cashClickValue;
    }

    public void WorkUpgrade()
    {
        if (cash >= workUpgradeCost)
        {
            cash -= workUpgradeCost;
            cashClickValue += workUpgradeLevel;

            workUpgradeLevel++;
            workUpgradeCost *= 2;
        }
    }

    public void Biz1()
    {
        if (cash >= biz1Cost)
        {
            cash -= biz1Cost;
            cashPerSec += biz1UpgradeLevel;

            biz1UpgradeLevel++;
            biz1Cost += 5;
        }
    }






	//// Use this for initialization
	//void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {
		
	//}
}
