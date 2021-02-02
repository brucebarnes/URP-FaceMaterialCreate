using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class MaterialGenerator : MonoBehaviour
{
    [MenuItem("Assets/Create Materials")]

     private static void CreateMaterials()
     {
         object[] mats = Resources.LoadAll("PolygonKids/Textures/Faces_Human", typeof(Texture2D));
         //Sets the FilePath where to save and checks if the folder exists, if not, creates it.
         string filePath = "Assets/Resources/PolygonKids/Textures/MaterialFaces/";
         if (!Directory.Exists(filePath))
         {
            Directory.CreateDirectory(filePath);
         }

         foreach (Object o in mats)
         {
  
             if (o.GetType() != typeof(Texture2D))
             {
                 Debug.LogError("This isn't a texture: " + o);
                 continue;
             }
 
             Debug.Log("Creating material from: " + o);
 
             Texture2D selected = o as Texture2D;
 
             Material material = new Material(Shader.Find("Universal Render Pipeline/Lit"));
             material.SetInt("_Surface",1);
             material.SetInt("_RenderQueueType", 4);
             //material.color = new Color(1.0f,1.0f,1.0f,0f);
             material.mainTexture = (Texture)o;
            
            string localPath = "Assets/Resources/PolygonKids/Textures/MaterialFaces/";

             string newAssetName = localPath + selected.name + ".mat";
 
             AssetDatabase.CreateAsset(material, newAssetName);
 
             AssetDatabase.SaveAssets();
 
         }
         Debug.Log("Done!");
     }
}
