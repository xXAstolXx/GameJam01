using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ResourceInventory : MonoBehaviour
{
    private float m_HP;
    private float m_Fuel;
    private float m_Oxygen;

    private GameObject amountHPUI;
    private GameObject amountFuelUI;
    private GameObject amountOxygenUI;

    private void Awake()
    {
        amountHPUI = GameObject.Find("HPAmount");
        amountFuelUI = GameObject.Find("FuelAmount");
        amountOxygenUI = GameObject.Find("OxyAmount");
    }

    public void AddResource(string resource, float amount)
    {
        if (resource == "HP")
        {
            m_HP += amount;
        }
        if (resource == "Fuel")
        {
            m_Fuel += amount;
        }
        if (resource == "Oxygen")
        {
            m_Oxygen += amount;
        }
    }

    public void RemoveResource(string resource, float amount)
    {
        if (resource == "HP")
        {
            m_HP -= amount;
        }
        if (resource == "Fuel")
        {
            m_Fuel -= amount;
        }
        if (resource == "Oxygen")
        {
            m_Oxygen -= amount;
        }
    }

    public float CheckResource(string resource)
    {
        if (resource == "HP")
        {
            return m_HP;
        }
        if (resource == "Fuel")
        {
            return m_Fuel;
        }
        if (resource == "Oxygen")
        {
            return m_Oxygen;
        }

        Debug.LogError("Lumi error: No resource requested! Returning 0f");
        return 0f;
    }

    private void UpdateUI()
    {
        amountHPUI.GetComponent<TextMeshProUGUI>().text = m_HP.ToString();
        amountFuelUI.GetComponent<TextMeshProUGUI>().text = m_Fuel.ToString();
        amountOxygenUI.GetComponent<TextMeshProUGUI>().text = m_Oxygen.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
    }
}
