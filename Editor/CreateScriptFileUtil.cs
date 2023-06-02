using UnityEditor;
using System.IO;

namespace AtsuAtsu.EntitiesUtil.editor
{
    public static class CreateScriptFileUtil
    {
        private const string PLUGIN_PATH = "Packages/com.atsuatsu.entities.editor/";
        public static void CreateScriptFile(string fileName, string newFileName)
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(Path.Combine(PLUGIN_PATH, $"Templates/{fileName}"), newFileName);
        }
    }
}
