using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using NaughtyAttributes;

public class LevelUpdateManager : MonoBehaviour
{
    //public
        [HideInInspector] public bool USEFUL = false;
        [HideInInspector] public int moneyUp = 0;
    //visible
    //[SerializeField] Transform A, B;
    //private

    private void Awake()
    {
        GameObject[] second_level = GameObject.FindGameObjectsWithTag("2");
        disable_loop(second_level);
        GameObject[] third_level = GameObject.FindGameObjectsWithTag("3");
        disable_loop(third_level);
        GameObject[] fourth_level = GameObject.FindGameObjectsWithTag("4");
        disable_loop(fourth_level);
    }
    private void disable_loop(GameObject[] array)
    {
        foreach(GameObject obj in array)
        { obj.SetActive(false); }
    }

    /*void Update()
    {
        if ((Mathf.Max(A.position.x, B.position.x) >= transform.position.x && transform.position.x >= Mathf.Min(A.position.x, B.position.x)) &&
            (Mathf.Max(A.position.y, B.position.y) >= transform.position.y && transform.position.y >= Mathf.Min(A.position.y, B.position.y)) &&
            (Mathf.Max(A.position.z, B.position.z) >= transform.position.z && transform.position.z >= Mathf.Min(A.position.z, B.position.z)))
            { Debug.Log("x :: " + transform.position.x + " y :: " + transform.position.y + " z :: " + transform.position.z + "  tag :: " + gameObject.tag); }



    }
    /*void BeforeButton()
    {
        GameObject intaractable = hit.collider.gameObject;
        GameObject sourceObj = intaractable.transform.root.gameObject;                
        Level_Local source = sourceObj.GetComponent<Level_Local>();  

        switch (intaractable.tag)
        {
            case "1": 
            {
                Vector3 pos = new Vector3(sourceObj.transform.position.x, sourceObj.transform.position.y + LightOffset, sourceObj.transform.position.z);
                currentLight = Instantiate(light_1, pos, Quaternion.identity, sourceObj.transform);

                upgradeButton.interactable = true;
                nameText.text = source.upgrade_name[0];
                descriptionText.text = source.upgrade_description[0];
                money = moneyName(source.upgrade_cost[0]);

                moneyUp = source.upgrade_cost[0];
                break; 
            }
            case "2": 
            { 
                Vector3 pos = new Vector3(sourceObj.transform.position.x, sourceObj.transform.position.y + LightOffset, sourceObj.transform.position.z);
                currentLight = Instantiate(light_2, pos, Quaternion.identity, sourceObj.transform);

                upgradeButton.interactable = true;
                nameText.text = source.upgrade_name[1];
                descriptionText.text = source.upgrade_description[1];
                money = moneyName(source.upgrade_cost[1]);

                moneyUp = source.upgrade_cost[1];
                break;  
            }
            case "3": 
            { 
                Vector3 pos = new Vector3(sourceObj.transform.position.x, sourceObj.transform.position.y + LightOffset, sourceObj.transform.position.z);
                currentLight = Instantiate(light_3, pos, Quaternion.identity, sourceObj.transform);

                upgradeButton.interactable = true;
                nameText.text = source.upgrade_name[2];
                descriptionText.text = source.upgrade_description[2];
                money = moneyName(source.upgrade_cost[2]);

                moneyUp = source.upgrade_cost[2];///////////
                break; 
            }
            case "4":
            {
                Vector3 pos = new Vector3(sourceObj.transform.position.x, sourceObj.transform.position.y + LightOffset, sourceObj.transform.position.z);
                currentLight = Instantiate(light_4, pos, Quaternion.identity, sourceObj.transform);
                
                upgradeButton.interactable = false;
                nameText.text = source.upgrade_name[3];
                descriptionText.text = source.upgrade_description[3];
                money = moneyName(source.upgrade_cost[3]);

                moneyUp = source.upgrade_cost[3];
                break;
            }    
        }
        if (intaractable.tag == "4") { upgradeButton.interactable = false; }
        moneyText.text = money;
        moneyUp = 0;
    }*/
}
