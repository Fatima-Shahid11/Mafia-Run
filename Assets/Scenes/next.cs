using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    
   
    public void level()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
          
    }
   
    
}
