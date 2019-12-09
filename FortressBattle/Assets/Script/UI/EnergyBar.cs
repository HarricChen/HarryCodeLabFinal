using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Image healthBar;
    public float healthBarPercentage;
    public DrawLine LineEnergy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBarPercentage = LineEnergy.totalCount / LineEnergy.totalInk;
        print(LineEnergy.totalCount / LineEnergy.totalInk);
        healthBar.fillAmount = healthBarPercentage;
    }
}
