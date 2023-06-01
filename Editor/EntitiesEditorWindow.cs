using UnityEditor;

public class EntitiesEditorWindow : EditorWindow
{
    private const string MENUROOT = "Assets/Create/Script for Entites/";
    [MenuItem(MENUROOT + "Component/UnmanagedComponent", priority = 10)]
    private static void CreateComponentDataCS()
    {
        CreateScriptFileUtil.CreateScriptFile("IComponent.txt", "ComponentData.cs");
    }
    [MenuItem(MENUROOT + "Component/ManagedComponent", priority = 11)]
    private static void CreateManagedComponentDataCS()
    {
        CreateScriptFileUtil.CreateScriptFile("ManagedIComponent.txt", "ManagedComponentData.cs");
    }
    [MenuItem(MENUROOT + "Component/IBufferElementData", priority = 12)]
    private static void CreateBufferElementCS()
    {
        CreateScriptFileUtil.CreateScriptFile("IBuffer.txt", "BufferElement.cs");
    }
    [MenuItem(MENUROOT + "System/ISystem", priority = 13)]
    private static void CreateSystemCS()
    {
        CreateScriptFileUtil.CreateScriptFile("ISystem.txt", "System.cs");
    }
    [MenuItem(MENUROOT + "System/SystemBase", priority = 14)]
    private static void CreateSystemBaseCS()
    {
        CreateScriptFileUtil.CreateScriptFile("SystemBase.txt", "SystemBase.cs");
    }
    [MenuItem(MENUROOT + "Authoring", priority = 15)]
    private static void CreateAuthoringCS()
    {
        CreateScriptFileUtil.CreateScriptFile("Baker.txt", "Authoring.cs");
    }
}
