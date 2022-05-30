using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int nb_pierre=0, nb_papier=0, nb_ciseaux=0;
        int pciseaux, ppapier, ppierre;
        int signe_prec = 0;
        int total = 0;
        int play_IA;
        if (signe_prec == 0)
        {
            ++nb_pierre;
            ++total;

        }
        if (signe_prec == 1)
        {
            ++nb_papier;
            ++total;
        }
        if (signe_prec == 2)
        {
            ++nb_ciseaux;
            ++total;
        }
        ppierre = 100 * nb_pierre / total;
        ppapier = 100 * nb_papier / total;
        pciseaux = 100 * nb_ciseaux / total;
        if(total == 0);
        {
            Debug.Log("total = " + total);
            play_IA = UnityEngine.Random.Range(0, 3);
            Debug.Log("IA joue = " + play_IA);
        }
        if((pciseaux>ppierre)&&(pciseaux>ppapier))
        {
            Debug.Log("Ciseaux = " + pciseaux + "%");
            play_IA = 1;
            Debug.Log("IA joue = " + play_IA);
        }
        if((ppierre>pciseaux)&&(ppierre>ppapier))
        {
            Debug.Log("Pierre = " + ppierre + "%");
            play_IA = 2;
            Debug.Log("IA joue = " + play_IA);
        }
        if((ppapier>pciseaux)&&(ppapier>ppierre))
        {
            Debug.Log("Papier = " + ppapier + "%");
            play_IA = 0;
            Debug.Log("IA joue = " + play_IA);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
