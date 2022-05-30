using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    int choice = 0;
    float nb_pierre=0, nb_papier=0, nb_ciseaux=0;
    float total = 1;
    int signe_prec = 999;
    int current_signe = 0;

    float pciseaux, ppapier, ppierre;
    

    public void ButtonOnclick(int button)
    {
        choice = button;
        IAtest(choice);
    }

    public void ValeurSigne (int signe)
    {
        if(signe == 0)
        {
            Debug.Log("Le signe est joué est la pierre ");
        }
        if(signe == 1)
        {
            Debug.Log("Le signe est joué est le papier ");
        }
        if(signe == 2)
        {
            Debug.Log("Le signe est joué est le ciseau ");
        }
    }
    void IAtest(int signe)
    {
        
        
        
        current_signe = signe;
        
        int play_IA;
        
        
        if(signe_prec == 999)
        {
            play_IA = UnityEngine.Random.Range(0, 3);
            // Debug.Log("Ciseaux = " + pciseaux + "%");
            // Debug.Log("Pierre = " + ppierre + "%");
            // Debug.Log("Papier = " + ppapier + "%");
            Debug.Log("IA joue = " + play_IA);
            ValeurSigne(play_IA);
        } else {
            if((pciseaux>=ppierre)&&(pciseaux>ppapier))
            {
                // Debug.Log("Ciseaux = " + pciseaux + "%");
                // Debug.Log("Pierre = " + ppierre + "%");
                // Debug.Log("Papier = " + ppapier + "%");
                play_IA = 0;
                Debug.Log("IA joue = " + play_IA);
                ValeurSigne(play_IA);
            }
            if((ppierre>=pciseaux)&&(ppierre>ppapier))
            {
                // Debug.Log("Ciseaux = " + pciseaux + "%");
                // Debug.Log("Pierre = " + ppierre + "%");
                // Debug.Log("Papier = " + ppapier + "%");
                play_IA = 1;
                Debug.Log("IA joue = " + play_IA);
                ValeurSigne(play_IA);
            }
            if((ppapier>=pciseaux)&&(ppapier>ppierre))
            {
                // Debug.Log("Ciseaux = " + pciseaux + "%");
                // Debug.Log("Pierre = " + ppierre + "%");
                // Debug.Log("Papier = " + ppapier + "%");
                play_IA = 2;
                Debug.Log("IA joue = " + play_IA);
                ValeurSigne(play_IA);
            }
        }
        if (current_signe == 0)
        {
            ++nb_pierre;
            Debug.Log("Pierre s'incrémente" + nb_pierre);
        }
        if (current_signe == 1)
        {
            ++nb_papier;
            Debug.Log("Papier s'incrémente" + nb_papier);
        }
        if (current_signe == 2)
        {
            ++nb_ciseaux;
            Debug.Log("Ciseaux s'incrémente" + nb_ciseaux);
        }
        ppierre = (nb_pierre / total) * 100;
        Debug.Log(nb_pierre / total);
        ppapier = (nb_papier / total) * 100;
        pciseaux = (nb_ciseaux / total) * 100;
        Debug.Log("Ciseaux = " + pciseaux + "%");
        Debug.Log("Pierre = " + ppierre + "%");
        Debug.Log("Papier = " + ppapier + "%");
        
        Debug.Log("Partie fini = " + total);
        signe_prec = current_signe;
        ++total;
    }

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
