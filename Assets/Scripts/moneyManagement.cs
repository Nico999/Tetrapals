using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyManagement : MonoBehaviour
{
    public int startMoney;
    public int currentMoney; 
    
    
    // Start is called before the first frame update
    void Start()
    {
        currentMoney = startMoney;
    }


    // Update is called once per frame
    //will make fixed update in future
    void Update() 
     
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            GainMoney(5);
        }
       
        if (Input.GetKeyDown(KeyCode.W))
        {
            InterestType1();
        }
    }

    
    // Increases current money by the specified integer
    public void GainMoney(int gainMoney) 
    {
        currentMoney += gainMoney;
        Debug.Log("CurrentAmount:" + currentMoney);
    }
   
    //   for every 10 gold, gain +1 on round start
    public void InterestType1()
    {
        if (currentMoney != 0)
        {
            int interestMultiplier = Mathf.FloorToInt(currentMoney / 10);
            GainMoney(interestMultiplier);
            Debug.Log("Interest amount:" + interestMultiplier);
        }
    }
 }



