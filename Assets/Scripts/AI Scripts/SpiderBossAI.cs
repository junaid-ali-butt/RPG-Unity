using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpiderBossAI : MonoBehaviour
{
    public GameObject TheDestination;
    NavMeshAgent TheAgent;
    public GameObject TheEnemy;
    public int AttackTrigger;
    public int DealingDamage;
    public GameObject Player;
    public float TargetDistance;
    public float AllowedRange=7.5f;
    public RaycastHit Shot;

    // Start is called before the first frame update
    void Start()
    {
        TheAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot)){
            TargetDistance=Shot.distance;

            if(TargetDistance <= AllowedRange){

                if(AttackTrigger == 0){
                    TheEnemy.GetComponent<Animation>().Play("Walk");
                    TheAgent.SetDestination(TheDestination.transform.position);
                }

            }else{
                TheEnemy.GetComponent<Animation>().Play("Idle");
            }

            if(AttackTrigger == 1){
                if(DealingDamage == 0){
                    TheEnemy.GetComponent<Animation>().Play("Attack");
                    StartCoroutine(TakingDamage());
                }
            }
        }
    }

    IEnumerator TakingDamage(){
        DealingDamage = 2;
        yield return new WaitForSeconds(1);
        if(SpiderEnemy.GlobalSpiderStatus != 6){
            //Health.HealthValue -= 1;
        }
        yield return new WaitForSeconds(0.5f);
        DealingDamage = 0;
    }

    void OnTriggerEnter(){
        AttackTrigger = 1;
    }

    void OnTriggerExit(){
        AttackTrigger = 0;
    }
}
