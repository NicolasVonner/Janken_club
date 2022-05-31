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
    int play_IA;
    int level=1;
    

    public void ButtonOnclick(int button)
    {
        choice = button;
        IAtest(choice);
    }

    public void ValeurSigne (int signe)
    {
        if(signe == 0)
        {
            Debug.Log("Le signe joué est la pierre ");
        }
        if(signe == 1)
        {
            Debug.Log("Le signe joué est le papier ");
        }
        if(signe == 2)
        {
            Debug.Log("Le signe joué est le ciseau ");
        }
    }
    void IAtest(int signe)
    {
        current_signe = signe;
        if(signe_prec == 999)
        {
            play_IA = UnityEngine.Random.Range(0, 3);
            Debug.Log("IA joue = " + play_IA);
            ValeurSigne(play_IA);
        } else {
            if(level==1)
            {
                Debug.Log("You are LEVEL 1");
                IALose();
            } else if(level==2)
            {
                Debug.Log("You are LEVEL 2");
                IAWin();
            }
        }

        if(play_IA == 0 && current_signe==1)
        {
            Debug.Log("Player WIN !!!");
        }
        if(play_IA == 1 && current_signe==2)
        {
            Debug.Log("Player WIN !!!");
        }
        if(play_IA == 2 && current_signe==0)
        {
            Debug.Log("Player WIN !!!");
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
        
        probability();
        
        signe_prec = current_signe;
        ++total;
        if (total == 5){
            total=1;
            ++level;
        }
    }

    void probability(){
        ppierre = (nb_pierre / total) * 100;
        Debug.Log(nb_pierre / total);
        ppapier = (nb_papier / total) * 100;
        pciseaux = (nb_ciseaux / total) * 100;
        Debug.Log("Ciseaux = " + pciseaux + "%");
        Debug.Log("Pierre = " + ppierre + "%");
        Debug.Log("Papier = " + ppapier + "%");
        Debug.Log("Partie fini = " + total);
    }

    void IAWin(){
        if((pciseaux>=ppierre)&&(pciseaux>ppapier))
        {
            play_IA = 0;
            Debug.Log("IA joue = " + play_IA);
            ValeurSigne(play_IA);
        }
        if((ppierre>=pciseaux)&&(ppierre>ppapier))
        {
            play_IA = 1;
            Debug.Log("IA joue = " + play_IA);
            ValeurSigne(play_IA);
        }
        if((ppapier>=pciseaux)&&(ppapier>ppierre))
        {
            play_IA = 2;
            Debug.Log("IA joue = " + play_IA);
            ValeurSigne(play_IA);
        }
    }

    void IALose(){
        if((pciseaux>=ppierre)&&(pciseaux>ppapier))
        {
            play_IA = 1;
            Debug.Log("IA joue = " + play_IA);
            ValeurSigne(play_IA);
        }
        if((ppierre>=pciseaux)&&(ppierre>ppapier))
        {
            play_IA = 2;
            Debug.Log("IA joue = " + play_IA);
            ValeurSigne(play_IA);
        }
        if((ppapier>=pciseaux)&&(ppapier>ppierre))
        {
            play_IA = 0;
            Debug.Log("IA joue = " + play_IA);
            ValeurSigne(play_IA);
        }
    }

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
