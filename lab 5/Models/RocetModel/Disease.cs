using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocetModel
{
    // класс хранящий информацию о всех возможных болезнях
    public static class Disease
    {
        // я решил, что у меня будут врачи: кардиолог, невролог, травматолог
        // я не стал искать настоящие названия болезней, поэтому сделал так:
        static string[] _allDisease = new string[]
        {
            "Смерть экипажа №1",
            "Смерть экипажа №2",
            "Смерть экипажа №3",
            "Есть травмы №1",
            "Есть травмы №2",
            "Есть травмы №3",
            "Все живы №1",
            "Все живы №2",
            "Все живы №2"
        };

        public static string[] AllDisease { get => _allDisease; }
    }
}
