using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPController : MonoBehaviour
{
    public Slider hpSlider;
    public int gaugeHP = 0;
    public int currentHP;
    public Image fillImage;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = gaugeHP;
        hpSlider.maxValue = gaugeHP;
        UpdateHP();
    }
    public void TakeDamage(int damage)
    {
        currentHP += damage;
        UpdateHP();
    }

    void UpdateHP()
    {
     hpSlider.value = currentHP;

        if (currentHP <= gaugeHP * 0.3f)
        {
            fillImage.color = Color.green;
        }
        else if (currentHP <= gaugeHP *0.6)
        {
            fillImage.color = Color.yellow;
        }
        else 
        {
            fillImage.color = Color.red;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
