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
    public Text bizLevel1TotalText;
    public double bizLevel1TotalO;
    public double bizLevel1TotalC;

    public void Start()
    {
        cashClickValue = 1;

        workUpgradeCost = 10;
        workUpgradeLevel = 1;

        bizUpgradeCost = 100;
        bizUpgradeROI = 1;

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

        workUpgradeText.text = "$" + workUpgradeCost.ToString("F0") + " \nROI: +$" + workUpgradeLevel + " per click";
        bizUpgradeText.text = "$" + bizUpgradeCost.ToString("F0") + "\nROI: +" + bizUpgradeROI + " Business Level";

        bizLevel1Text.text = "Cash: $" + bizLevel1Cost.ToString("F0") + "\nBusiness Level: " + bizLevel1Level + "\nROI: +$" + bizLevel1ROI + " cash/sec";
        bizLevel1TotalText.text = "Owned: " + bizLevel1TotalO.ToString("F0") + "\nCash/sec: $" + bizLevel1TotalC.ToString("F0");
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

            workUpgradeCost += 10;
        }
    }

    public void BizUpgrade()
    {
        if (cash >= bizUpgradeCost)
        {
            cash -= bizUpgradeCost;
            bizLevel += bizUpgradeROI;

            bizUpgradeCost += 50;
        }
    }

    public void Biz1()
    {
        if (bizLevel >= 100 && bizLevel1Level == 10)
        {
            if (cash >= bizLevel1Cost && bizLevel >= bizLevel1Level)
            {
                cash -= bizLevel1Cost;
                cashPerSec += bizLevel1ROI;

                bizLevel1TotalO++;
                bizLevel1TotalC += bizLevel1ROI;

                bizLevel1ROI += 10;
                bizLevel1Cost *= 2;
            }
        }
        else if (bizLevel >= 10 && bizLevel1Level >= 10)
        {
            if (cash >= bizLevel1Cost && bizLevel >= bizLevel1Level)
            {
                cash -= bizLevel1Cost;
                cashPerSec += bizLevel1ROI;

                bizLevel1TotalO++;
                bizLevel1TotalC += bizLevel1ROI;

                bizLevel1ROI = 10;
                bizLevel1Cost += 100;
            }
        }
        else if (cash >= bizLevel1Cost && bizLevel >= bizLevel1Level)
        {
            cash -= bizLevel1Cost;
            cashPerSec += bizLevel1ROI;

            bizLevel1TotalO++;
            bizLevel1TotalC += bizLevel1ROI;

            bizLevel1ROI++;
            bizLevel1Level++;
            bizLevel1Cost += 25;
        }
    }


    //public string NumCheck(double x)
    //{
    //    string y;
    //    switch (x)
    //    {
    //        case x > 1000000:
    //            y = "million";
    //            break;
    //        default:
    //    }
    //    y = "bunch";
    //    return y;
    //}
}
