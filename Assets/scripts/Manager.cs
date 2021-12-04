using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //***

public class Manager : MonoBehaviour
{
    [HideInInspector]
    public static Manager Instance { get; private set; } //used for singleton, can be referenced by any other script

    private void Awake()
    {
        if (Instance != null && Instance != this) //singleton pattern
            Destroy(this.gameObject);
        else
            Instance = this;
    }

    private GameObject[] _targets;
    public string FactoryTag = "Factory";
    public string Food1 = "chickenleg";
    public string Food2 = "hamburger";
    public string Food3 = "shrimp";
    public string Food4 = "pineapple";
    public string Food5 = "icecream";
    public string Food6 = "fries";
    public string[] Foods = new string[] { "chikenleg", "hamburger", "shrimp", "pineapple", "icecream", "fries" };
    public GameObject target;
    public string food;
    public int start = 1;
    public int end = 1;

    // Start is called before the first frame update

    public void Start()
    {
        _targets = GameObject.FindGameObjectsWithTag(FactoryTag);

        int start = Random.Range(0, Foods.Length);
        int end = Random.Range(0, Foods.Length);

        if (start == end)
        {
            end += 1;
            if (end == Foods.Length) { end = 0; }
        }
        Debug.Log(start);
        Debug.Log(end);
        food = Foods[start];//for picking up the tag
        GameObject target = _targets[end];//target factory
        GameObject selectedfood = GameObject.Find(food);//for chossing all the selected food
        string TargetName = target.name;//target factory`s name
        //Debug.Log(food);
        //Debug.Log(target);
    }
}

/*public GameObject GetTarget()
{
    int targetIndex = Random.Range(0, _targets.Length);
    GameObject target = _targets[targetIndex];

    int startIndex = targetIndex; //used to test if the index wraps back on itself
    while (_occupiedTargets.Contains(target))
    {
        targetIndex++;
        if (targetIndex >= _targets.Length) { targetIndex = 0; } //loop back to array start
        target = _targets[targetIndex];
        if (startIndex == targetIndex) { break; } //this means indices wrapped
    }
    return target;
}*/

// Update is called once per frame