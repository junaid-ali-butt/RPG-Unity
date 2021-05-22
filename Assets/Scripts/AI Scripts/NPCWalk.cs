using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWalk : MonoBehaviour
{
    public int Xpos;
    public int Zpos;
    public float WalkSpeed = 0.02f;
    public GameObject NPCDestination;
    
    // Start is called before the first frame update
    void Start()
    {
        Xpos = Random.Range(46,53);
        Zpos = Random.Range(18,21);
        NPCDestination.transform.position = new Vector3(Xpos, 0, Zpos);
        StartCoroutine(RunRandomWalk());
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(NPCDestination.transform);
        transform.position = Vector3.MoveTowards(transform.position, NPCDestination.transform.position, WalkSpeed);
    }

    IEnumerator RunRandomWalk(){
        gameObject.GetComponent<Animation>().Play("Walk");
        // yield return new WaitForSeconds(5);
        // if(transform.position.x >= Xpos && transform.position.z >= Zpos){
        //     gameObject.GetComponent<Animation>().Play("Idle2");
        //     yield return new WaitForSeconds(2);
        // }
        do{
            yield return new WaitForSeconds(1);
        }while(transform.position != NPCDestination.transform.position);
        gameObject.GetComponent<Animation>().Play("Idle2");
        yield return new WaitForSeconds(2);
        Xpos = Random.Range(46,53);
        Zpos = Random.Range(18,22);
        NPCDestination.transform.position = new Vector3(Xpos, 0, Zpos);
        StartCoroutine(RunRandomWalk());
    }
}
