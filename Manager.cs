using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //***

public class Manager : MonoBehaviour
{
    [HideInInspector]
    public static Manager Instance { get; private set; } //used for singleton, can be referenced by any other script

    public Text TextUI; //***
    public string TargetTag = "Target";
    public string FoodTag = "Food";
    public string AgentTag = "Agent";

    private void Awake()
    {
        if (Instance != null && Instance != this) //singleton pattern
            Destroy(this.gameObject);
        else
            Instance = this;
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    /*public void RemoveTargetFromList(GameObject target)
    {
        _occupiedTargets.Remove(target);
    }

    public bool IsTaskCompelete(GameObject target)
    {
        return _occupiedTargets.Contains(target);
    }*/
}