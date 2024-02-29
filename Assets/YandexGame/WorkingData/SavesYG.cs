
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;

        // Тестовые сохранения для демо сцены
        // Можно удалить этот код, но тогда удалите и демо (папка Example)
        public bool haveUnvisible = false;                       // Можно задать полям значения по умолчанию
                     // Можно задать полям значения по умолчанию
        public bool[] locks = new []{true, false, true, false, false, true, true, false};
        



    }
}
