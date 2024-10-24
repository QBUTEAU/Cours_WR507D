using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement; // important pour pouvoir utiliser SceneManager.LoadScene()
using TMPro;   

public class StepManager : MonoBehaviour
{
	public int Step  = 0;
    public TMP_Text StepText; // va permettre d'accéder au texte de la zone d'affichage de la checklist
	public List<string> checklist;
    public GameObject[] arrows;

    void Start()
    {
    	// Liste de chaque étape en format texte. Peut être rempli dans l'éditeur
        // dans ce cas, les valeurs ci-dessous seront ignorées.
        if (checklist is null || checklist.Count == 0)
		{
			checklist = new List<string>(5)
			{
				"Mettez l'imprimante sur ON.\n",
				"Inspecter le compartiment d'impression.\n",
				"Brancher la clé USB dans le port.\n",
				"Appuyez sur le bouton \"IMPRIMER\".\n"
			};
		}
        AdvanceToStep(1);
    }

    public void ResetTutorial()
    {
        SceneManager.LoadScene("TP3-1"); // À renommer selon le nom de votre scène.
    }

    public void AdvanceToStep(int stepToAdvance)
    {
		// On ne passe à l'étape suivante que si on est à l'étape d'avant (interdire de sauter une étape)
		if (stepToAdvance == Step + 1)
		{
			if (Step < checklist.Count)
			    StepText.text += checklist[Step] + "\n";
            else
                StepText.text = "Et voilà ! Vous pouvez recommencer le guide en cliquant sur le bouton.";
            
            if (Step-1 >= 0)
            	arrows[Step-1]?.SetActive(false); // Cacher la flèche d'avant (si elle existe)
            if (Step < arrows.Length)
            	arrows[Step]?.SetActive(true); // Afficher la flèche d'après (si elle existe)

            Step++;
		}
    }
}
