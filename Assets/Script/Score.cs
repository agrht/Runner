using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
   private int _score;
   public TMP_Text Text;
   private void OnTriggerEnter2D(Collider2D col)
   {
      if (col.CompareTag("Enomy"))
      {
         _score++;
         Text.text = _score.ToString();
      }
   }
}
