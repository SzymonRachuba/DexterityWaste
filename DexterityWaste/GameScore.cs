using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexterityWaste
{
    /**
     * Klasa przechowująca informacje numeryczne o wynikach gry
     */
    class GameScore
    {
        /**Aktualny wynik*/
        public int score;
        /**Aktualny poziom*/
        public int level;
        /**Ilość otrzymanych gwiazdek*/
        public int stars;
        /**Maksymalny poziom*/
        public int maxLevel;
        /**Czas rozgrywki*/
        public int time;
        /**Ilość błędów, które można popełnić*/
        public int hp;
        /**Tablica przechowująca informacje o ilości zebranych odpadów danego rodzaju*/
        public int[] trashCollected;

        /**
         * Konstruktor klasy ustawiający początkowe wartości zmiennych
         */
        public GameScore()
        {
            hp = 5;
            level = 1;
            stars = 0;
            trashCollected = new int[5];
            maxLevel = 3;
            time = 90;
            score = 0;
        }
    }
}
