using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
//using Unity.VisualScripting.Antlr3.Runtime.Tree;

public class MenuBehaivour : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator animator;
 public void CambiarEscenaSample()
    {
        StartCoroutine(CargarEscena("SampleScene"));  
    }

    public void CambiarEscenaDos()
    {
        StartCoroutine(CargarEscena("SceneDos"));
    }

    IEnumerator CargarEscena(string nombre)
    {
        animator.SetBool("Activar",true);
        yield return new WaitForSeconds(2); 
        SceneManager.LoadScene(nombre);  
    }
}
