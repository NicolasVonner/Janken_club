using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class signe : MonoBehaviour
{
    public static int cpuHandIndex;
  //public TMP_Text stateText;
    public TMPro.TMP_Text stateText;
    public TMPro.TMP_Text UserLifeText;
    public TMPro.TMP_Text CpuLifeText;

    public int user_life=45;
    public int cp_life =45;


    Dictionary<int, string> dictSIGNE = new Dictionary<int, string>()
    {
        {0, "Pierre"},
        {1, "Feuille"},
        {2, "Ciseaux"},
        {3, "Dragon"},
        {4, "Loup"},
        {5, "Lumiere"},
        {6, "Air"},
    };
    // public GameObject LightSquare;


    public bool critical()
    {

        int crit = UnityEngine.Random.Range(1, 100);
        // (float)random.NextDouble(1, 100);
        if (crit >= 6)
        {
            return false;
        }
        else
        {
            return true;
        }

    }

    public int GetDamage(int attacker, int defender)
    {
        int damage = attacker;
        int modifier = 1;/// * (1.0 - 0.85f) + 0.85f;
        
        if (critical()) //determines critical hit! proba  6,25%
        {
            Debug.Log("Critical Hit!");
            modifier *= 2;
        }

        damage *= modifier;
        Debug.Log("damage :" + damage);
        return damage;
    }


    void userWinRound(int user_choice, int cp_choice)
    {
        /* Pierre l'emporte sur Ciseaux, Ciseaux leemporte sur Feuille et Feuille l'emporte sur Pierre.
        Si les deux actions sont identiques ceest une eegalitee et personne ne marque de point. */
        if (user_choice == cp_choice)
        {
            Debug.Log("egalite");//en cas deeegalite
            stateText.text = "egalite";
            // Debug.Log(user_choice);
            // Debug.Log(cp_choice);
            



        }
        else if ((user_choice == 0 && cp_choice == 2) ||
          (user_choice == 1 && cp_choice == 0) ||
          (user_choice == 2 && cp_choice == 1))
        {

            Debug.Log("Gagner");
            Debug.Log("Attaque"); //en cas de victoire du joueur
            stateText.text = "Gagner";
            //Debug.Log(user_choice);
            // Debug.Log(cp_choice);
            cp_life = cp_life - GetDamage(5,2);
            CpuLifeText.text = "vie:" + cp_life + "/ 45";
        }
        else
        {
            Debug.Log("Perdu");
            // Debug.Log("Defend");//en cas de victoire de l'ordinateur
            stateText.text = "Perdu";
            //Debug.Log(user_choice);
            // Debug.Log(cp_choice);
            user_life = user_life - GetDamage(5, 2);
            
            UserLifeText.text = "vie:" + user_life + "/ 45";

         
            //      user_life;
            // cp_life;

            //       UserLifeText;
            //CpuLifeText.text=

        }
    }

    private int playHand()
    {

        cpuHandIndex = UnityEngine.Random.Range(0, 3);
        Debug.Log(cpuHandIndex);
        return cpuHandIndex;
    }

    public void Pierre()
    {
        int user_choice = 0;
        cpuHandIndex = playHand();
        userWinRound(user_choice, cpuHandIndex);
    }

    public void Feuille()
    {
        int user_choice = 1;
        cpuHandIndex = playHand();
        userWinRound(user_choice, cpuHandIndex);
    }

    public void Ciseau()
    {
        int user_choice = 2;
        cpuHandIndex = playHand();
        userWinRound(user_choice, cpuHandIndex);

    }


    


}
