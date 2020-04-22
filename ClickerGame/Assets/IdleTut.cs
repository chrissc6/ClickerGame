using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleTut : MonoBehaviour
{
    public Text cashText;
    public double cash;
    public Text cashClickValueText;
    public double cashClickValue;

    public Text cashPerSecText;
    public double cashPerSec;

    public Text bizLevelText;
    public double bizLevel;

    public Text workUpgradeText;
    public double workUpgradeCost;
    public double workUpgradeLevel;

    public Text bizUpgradeText;
    public double bizUpgradeCost;
    public double bizUpgradeROI;

    public Text bizLevel1Text;
    public double bizLevel1Cost;
    public double bizLevel1Level;
    public double bizLevel1ROI;

    //public Text biz1Text;
    //public double biz1Cost;
    //public double biz1UpgradeLevel;

    public void Start()
    {
        cashClickValue = 1;

        workUpgradeCost = 10;
        workUpgradeLevel = 1;

        bizUpgradeCost = 20;
        bizUpgradeROI = 1;

        //biz1Cost = 25;
        //biz1UpgradeLevel = 1;

        bizLevel1Cost = 25;
        bizLevel1Level = 1;
        bizLevel1ROI = 1;

    }

    public void Update()
    {
        cashText.text = "Cash: $" + cash.ToString("F0");

        cashClickValueText.text = "Cash Per Click: $" + cashClickValue.ToString("F0");
        cashPerSecText.text = "Cash Per Sec: $" + cashPerSec.ToString("F0");
        bizLevelText.text = "Business Level: " + bizLevel.ToString("F0");

        workUpgradeText.text = "Learn: $" + workUpgradeCost.ToString("F0") + " \nROI: +$" + workUpgradeLevel + " per click";
        bizUpgradeText.text = "Learn: $" + bizUpgradeCost.ToString("F0") + "\nROI: +" + bizUpgradeROI + " Business Level";

        bizLevel1Text.text = "Cash: $" + bizLevel1Cost.ToString("F0") + "\nBusiness Level: " + bizLevel1Level + "\nROI: $" + bizLevel1ROI + " cash/sec";
        //biz1Text.text = "Lemonade Stand $" + biz1Cost.ToString("F0") + " \nROI: +$" + biz1UpgradeLevel + " cash /sec";

        

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

            //workUpgradeLevel++;
            workUpgradeCost += 25;
        }
    }

    public void BizUpgrade()
    {
        if (cash >= bizUpgradeCost)
        {
            cash -= bizUpgradeCost;
            bizLevel += bizUpgradeROI;

            //workUpgradeLevel++;
            bizUpgradeCost += 25;
        }
    }

    public void Biz1()
    {
        if (cash >= bizLevel1Cost && bizLevel >= bizLevel1Level)
        {
            cash -= bizLevel1Cost;
            cashPerSec += bizLevel1ROI;

            //bizLevel1ROI++;
            bizLevel1ROI++;
            bizLevel1Level++;
            bizLevel1Cost += 25;
        }
    }






	//// Use this for initialization
	//void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {
		
	//}
}
