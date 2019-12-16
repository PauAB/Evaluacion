using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SerializeManager : MonoBehaviour {

    BinaryFormatter formatter;
    Stream stream;

    PetoonsStudio.Evaluation.Personaje personaje;
    PetoonsStudio.Evaluation.Personaje.Faccion faccion;    

    void Start()
    {
        formatter = new BinaryFormatter();
        stream = new FileStream("save.dat", FileMode.Create, FileAccess.Write, FileShare.None);
        personaje = new PetoonsStudio.Evaluation.Personaje();
        faccion = PetoonsStudio.Evaluation.Personaje.Faccion.Azul;    
        personaje.Hogar = faccion;        

        Serialize();
    }

    private void Serialize()
    {
        formatter.Serialize(stream, personaje);
        stream.Close();

        Debug.Log("Serialized");
    }
}