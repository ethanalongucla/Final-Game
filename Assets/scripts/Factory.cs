using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public GameObject Prefab;
    public string TargetTag;
    public int MakeLimit = 6; //maximum agents before destruction
    private int _makeCount = 0; //each time we make an agent, add to count
    private GameObject Target;

    public float MakeRate = 2.0f;
    public Renderer rend;
    private float _lastMake = 0;

    // Start is called before the first frame update
    private void Start()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag(TargetTag);
        Target = targets[Random.Range(0, targets.Length)];
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        //guard statement
        if (Target == null) { return; }

        //destroy factory when limit reached
        if (_makeCount >= MakeLimit)
        {
            Destroy(gameObject);
        }

        _lastMake += Time.deltaTime; //_lastMake = _lastMake + Time.deltaTime;
        if (_lastMake > MakeRate)
        {
            //Debug.Log("Make");
            _lastMake = 0; //reset time counter
            _makeCount++; //increase agent make count by one
            GameObject go = Instantiate(Prefab, this.transform.position, Quaternion.identity);
            MobileUnit mu = go.GetComponent<MobileUnit>();
            mu.Target = Target;
        }
    }

    public void changecolorred()
    {
        rend.material.SetColor("_Color", Color.red);
    }

    public void changecolorblue()
    {
        rend.material.SetColor("_Color", Color.blue);
    }

    public void changecoloryellow()
    {
        rend.material.SetColor("_Color", Color.yellow);
    }
}