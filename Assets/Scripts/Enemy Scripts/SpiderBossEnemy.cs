using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBossEnemy : MonoBehaviour
{
    public int EnemyHealth = 5;
	public GameObject TheSpider;
	public int SpiderStatus;
	public int BaseXP = 50;
	public int CalculatedXP;
    public SpiderBossAI SpiderAIScript;
    public static int GlobalSpider;
    public GameObject OldNPC;
    public GameObject NewNPC;

    // Start is called before the first frame update
    void Start()
    {
        SpiderAIScript = GetComponent<SpiderBossAI>();
    }

    void DeductPoints(int DamageAmount){
        EnemyHealth -= DamageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        GlobalSpider = SpiderStatus;
        if(EnemyHealth <= 0){
            if(SpiderStatus == 0){
                StartCoroutine(DeathSpider());
            }
        }
    }

    IEnumerator DeathSpider(){
        SpiderAIScript.enabled = false;
        SpiderStatus = 6;
        CalculatedXP = BaseXP * GlobalLvl.CurrentLevel;
        yield return new WaitForSeconds(0.5f);
        TheSpider.GetComponent<Animation>().Play("Death");
        yield return new WaitForSeconds(2);
        TheSpider.GetComponent<Animation>().enabled = false;
        OldNPC.SetActive(false);
        NewNPC.SetActive(true);
        QuestManager.SubQuestNumber = 4;
    }
}
