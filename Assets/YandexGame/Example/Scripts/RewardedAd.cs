using UnityEngine;
using UnityEngine.UI;

namespace YG.Example
{
    public class RewardedAd : MonoBehaviour
    {
        



        private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;
        private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

        void Rewarded(int id)
        {
            if (id == 1)
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().haveUnreal = true;
                GameObject.Find("GameManager").GetComponent<GameManager>().MySave();
            }
            else if (id == 2)
            {
                int i = 0;
                foreach (var locker in GameObject.Find("GameManager").GetComponent<GameManager>().locked)
                {
                    GameObject.Find("GameManager").GetComponent<GameManager>().locked[i] = true;
                    GameObject.Find("GameManager").GetComponent<GameManager>().MySave();
                    i++;
                }
            }

        }


        public void RewAdd(int id)
        {
            // Вызываем метод открытия видео рекламы
            YandexGame.RewVideoShow(id);
        }
    }
}