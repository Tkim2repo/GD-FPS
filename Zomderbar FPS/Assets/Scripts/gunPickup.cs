using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunPickup : MonoBehaviour
{
    [SerializeField] gunStats gunStat;
    [SerializeField] GameObject gunHUD;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.instance.playerScript.gunPickup(gunStat.shootRate, gunStat.shootDist, gunStat.shootDmg, gunStat.ammoCapacity, currentGunHUD, gunStat);
            Destroy(gameObject);
        }
    }

   
}
