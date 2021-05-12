﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderAI : MonoBehaviour
{
    public GameObject Player;
    public float TargetDistance;
    public float AllowedRange=30;
    public GameObject TheEnemy;
    public float EnemySpeed;
    public int AttackTrigger;
    public RaycastHit Shot;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot)){
            TargetDistance=Shot.distance;

            if(TargetDistance <= AllowedRange){
                EnemySpeed=0.1f;

                if(AttackTrigger == 0){
                    TheEnemy.GetComponent<Animation>().Play("walk");
                    transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, EnemySpeed);
                }else{
                    EnemySpeed=0;
                    TheEnemy.GetComponent<Animation>().Play("idle");
                }
            }

            if(AttackTrigger == 1){
                EnemySpeed=0;
                TheEnemy.GetComponent<Animation>().Play("attack");
            }
        }
    }

    void OnTriggerEnter() {
        AttackTrigger = 1;
    }

    void OnTriggerExit() {
        AttackTrigger = 0;
    }
}