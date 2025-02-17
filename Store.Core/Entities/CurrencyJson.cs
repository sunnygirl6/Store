﻿using Newtonsoft.Json;

namespace Store.Core.Entities
{
    public class CurrencyJson
    {
        [JsonIgnore]
        public decimal USD_in { get; set; } // курс покупки структурным подразделением Доллар США
        public decimal USD_out { get; set; } // курс продажи структурным подразделением Доллар США
        public decimal EUR_in { get; set; } // курс покупки структурным подразделением Евро
        public decimal EUR_out { get; set; } // курс продажи структурным подразделением Евро
        public decimal RUB_in { get; set; } // курс покупки структурным подразделением(100 ед.) Российский рубль
        public decimal RUB_out { get; set; } // курс продажи структурным подразделением(100 ед.) Российский рубль
        public decimal GBP_in { get; set; } // курс покупки структурным подразделением Фунт стерлингов
        public decimal GBP_out { get; set; } // курс продажи структурным подразделением Фунт стерлингов
        public decimal CAD_in { get; set; } // курс покупки структурным подразделением Канадский доллар
        public decimal CAD_out { get; set; } // курс продажи структурным подразделением Канадский доллар
        public decimal PLN_in { get; set; } // курс покупки структурным подразделением Польский злотый
        public decimal PLN_out { get; set; } // курс продажи структурным подразделением Польский злотый
        public decimal UAH_in { get; set; } // курс покупки структурным подразделением(100 ед.) Украинская гривна
        public decimal UAH_out { get; set; } // курс продажи структурным подразделением(100 ед.) Украинская гривна
        public decimal SEK_in { get; set; } // курс покупки структурным подразделением(10 ед.) Шведская крона
        public decimal SEK_out { get; set; } // курс продажи структурным подразделением(10 ед.) Шведская крона
        public decimal CHF_in { get; set; } // курс покупки структурным подразделением(10 ед.) Швейцарский франк
        public decimal CHF_out { get; set; } // курс продажи структурным подразделением(10 ед.) Швейцарский франк
        public decimal JPY_in { get; set; } //  курс покупки структурным подразделением(100 ед.) Японская иена
        public decimal JPY_out { get; set; } // курс продажи структурным подразделением(100 ед.) Японская иена
        public decimal CNY_in { get; set; } // курс покупки структурным подразделением(10 ед.) Китайский юань
        public decimal CNY_out { get; set; } // курс продажи структурным подразделением(10 ед.) Китайский юань
        public decimal CZK_in { get; set; } // курс покупки структурным подразделением(100 ед.) Чешская крона
        public decimal CZK_out { get; set; } // курс продажи структурным подразделением(100 ед.) Чешская крона
        public decimal NOK_in { get; set; } // курс покупки структурным подразделением(10 ед.) Норвежская крона
        public decimal NOK_out { get; set; } // курс продажи структурным подразделением(10 ед.) Норвежская крона
        public decimal USD_EUR_in { get; set; } // курс конверсии Доллар США / Евро(USD/EUR) (покупка структурным подразделением)
        public decimal USD_EUR_out { get; set; } // курс конверсии Доллар США / Евро(USD/EUR) (продажа структурным подразделением)
        public decimal USD_RUB_in { get; set; } // курс конверсии Доллар США / Российский рубль(USD/RUB) (покупка структурным подразделением)
        public decimal USD_RUB_out { get; set; } // курс конверсии Доллар США / Российский рубль(USD/RUB) (продажа структурным подразделением)
        public decimal RUB_EUR_in { get; set; } // курс конверсии Российский рубль / Евро(RUB/EUR) (покупка структурным подразделением)
        public decimal RUB_EUR_out { get; set; } // курс конверсии Российский рубль / Евро(RUB/EUR) (продажа структурным подразделением)
                                                 //        public int filial_id  { get; set; } // id подразделения банка
                                                 //info_worktime   {get; set; } // режим работы структурного подразделения(строка с разбивкой по дням)
                                                 //filials_text  {get; set; } // наименование структурного подразделения банка
                                                 //name_type  {get; set; } // тип населенного пункта местонахождения структурного подразделения
                                                 //name  {get; set; } // название населенного пункта местонахождения структурного подразделения
                                                 //street_type  {get; set; } // тип улицы местонахождения структурного подразделения
                                                 //street  {get; set; } // название улицы местонахождения структурного подразделения
                                                 //home_number  {get; set; } // номер дома местонахождения структурного подразделения
    }
}
