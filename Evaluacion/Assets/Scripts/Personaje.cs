using System;
using UnityEditor;
using UnityEngine;
/// <summary>
/// Author: Alejandro Cortés Cabrejas
/// </summary>
/// 
namespace PetoonsStudio.Evaluation
{
    /// <summary>
    /// Character definition
    /// </summary>  
    [Serializable]
    public class Personaje : MonoBehaviour
    {
        public enum Faccion
        {
            Roja, Verde, Azul
        }

        public int Vida = 150;
        public int Mana = 100;

        public Stats Stats;

        public Faccion Hogar;        
    }

    /// <summary>
    /// Stats definition
    /// </summary>
    [Serializable]
    public class Stats
    {
        public int Ataque = 20;
        public int Defensa = 15;
        public int Velocidad = 3;
    }

     [CustomEditor(typeof(Personaje))]
     public class MyCustomEditor : Editor
    {
        override public void OnInspectorGUI()
        {
            Personaje personaje = FindObjectOfType<Personaje>();                        

            personaje.Vida = EditorGUILayout.IntSlider("Vida", personaje.Vida, 0, 150);
            personaje.Mana = EditorGUILayout.IntSlider("Mana", personaje.Mana, 0, 100);

            if (personaje.Vida >= 100)
            {
                personaje.Stats.Ataque = EditorGUILayout.IntField("Ataque", personaje.Stats.Ataque);
                personaje.Stats.Defensa = EditorGUILayout.IntField("Defensa", personaje.Stats.Defensa);
                personaje.Stats.Velocidad = EditorGUILayout.IntField("Velocidad", personaje.Stats.Velocidad);                
            }
        }
    }
}
