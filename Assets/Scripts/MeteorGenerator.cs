using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorGenerator : MonoBehaviour
{
    public GameObject Meteor;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GeneriereCountdown());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnObject()
    {
        float y_pos = Random.Range(-5f, 5f);
        Vector2 position=new Vector2(13f,y_pos);
        GameObject new_meteor = Instantiate(Meteor,position,Quaternion.identity);
        //float scale_num = Random.Range(1,4);
        //new_meteor.transform.scale=new Vector3(scale_num,scale_num,1);
    }
    
    IEnumerator GeneriereCountdown()
    {
        while (true)
        {
            spawnObject();
            yield return new WaitForSeconds(2f);
        }
    }
}