# URP_KidFace_Material_Creator
 An editor script that at the push of a button automatically creates the materials required to make the face texture materials needed for Synty Studio's Polygon Kids to work with Unity's URP.
 
 Preview of the Menu Button and What the File Structure would look like
 <img src=https://github.com/brucebarnes/URP-FaceMaterialCreate/blob/main/DemoEditorButtonAndFileStructure.gif/>
 
Instructions
1) Install MaterialGenerator.cs in folder named Editor (Create if you don't have) || Import URP-FadFaceMaterialCreator.unitypackage into your project
2) Install entire PolygonKids asset into a folder named Resources  should look like
   /Assets/Resources/PolygonKids/Materials
                                /Models
                                /Prefabs
                                /Scenes
                                /Shaders
                                /Textures
  *Note: if you copy it over in the file system, it may take a minute to import the files*
3) Click on the Toolbar, Assets->Create Materials
4) Wait for the "Done!" to populate in the Console
5) URP Face Materials are created in /Assets/Resources/PolygonKids/Textures/MaterialFaces
6) Use these materials by Changing the Material set on each Prefab

    *Note1: If all your prefabs are still pink, you will want to go to Edit->Render Pipeline->Universal Render Pipeline -> Upgrade Project Materials to URP*

    *Note2: The location to change Face Materials is in each Prefab/Root/Hips/Spine1/Spine2/Spine3/Neck/Head/SM_Chr_Kid_Face_01.*

    *Note3: I have ran into a bug that the first time the material is placed on SM_Chr_Kid_Face_01, it might look weird or dark.  If you instead click on the Shader within the Component it will load correctly and will load correctly for future iterations.*
    
<img src=https://github.com/brucebarnes/URP-FaceMaterialCreate/blob/main/DemoChangeFaceAndBugFix.gif/>

<h2>License</h2>
 MIT License
<h1>Questions?</h1>
PM me @majorbatman#7731 on Official Synty Studios Discord
