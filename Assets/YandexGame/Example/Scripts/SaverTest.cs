using UnityEngine;
using UnityEngine.UI;

namespace YG.Example
{
    public class SaverTest : MonoBehaviour
    {
        [SerializeField] InputField integerText;
        [SerializeField] InputField stringifyText;
        [SerializeField] Text systemSavesText;
        [SerializeField] Toggle[] booleanArrayToggle;

        private void OnEnable() => YandexGame.GetDataEvent += GetLoad;
        private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

        private void Awake()
        {
            if (YandexGame.SDKEnabled)
                GetLoad();
        }

        public void Save()
        {

        }

        public void Load() => YandexGame.LoadProgress();

        public void GetLoad()
        {
            integerText.text = string.Empty;

        }
    }
}