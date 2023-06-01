using Unity.VisualScripting;
using UnityEditor;

public static class CreateScriptFileUtil
{
    private const string PLUGIN_PATH = "Packages/com.atsuatsu.entities.editor/";
    public static void CreateScriptFile(string fileName, string newFileName)
    {
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(System.IO.Path.Combine(PLUGIN_PATH, $"Templates/{fileName}"), newFileName);
    }
}
