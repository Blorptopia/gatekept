using MelonLoader;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Gatekept
{
    public static class BuildInfo
    {
        public const string Name = "Gatekept";
        public const string Description = "Speedrunning the gatekept game";
        public const string Author = "Blorptopia";
        public const string Company = null;
        public const string Version = "1.0.0";
        public const string DownloadLink = "https://github.com/blorptopia/gatekept";
    }

    public class Gatekept : MelonMod
    {
        private const string gameSceneName = "GameScene";
        private double runDuration = 0;

        public override void OnSceneWasInitialized(int buildindex, string sceneName)
        {
            if (sceneName == Gatekept.gameSceneName)
            {
                this.runDuration = 0;
            }
        }


        public override void OnUpdate()
        {
            var scene = SceneManager.GetActiveScene();
            if (UnityEngine.Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(scene.name);
            }
            var instance = Melon<Gatekept>.Instance;
            if (scene.name == Gatekept.gameSceneName)
            {
                this.runDuration += Time.deltaTime;
            }
        }

        public override void OnGUI()
        {
            var size = new UnityEngine.Rect(0, 0, 500, 500);
            UnityEngine.GUI.Label(size, "<size=50>" + this.formatRunDuration());
        }
        private string formatRunDuration()
        {
            var minutes = Mathf.Floor((float)this.runDuration / 60);
            var rawSeconds = (float)this.runDuration % 60;
            var seconds = Mathf.Floor(rawSeconds);
            var ms = Mathf.Floor((rawSeconds % 1) * 1000);
            return minutes + ":" + seconds + ":" + ms;
        }
    }
}
