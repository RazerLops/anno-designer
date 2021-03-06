﻿using System;
using System.Collections.Generic;

namespace PresetParser
{
    public static class ExtraPresets
    {
        public static IEnumerable<ExtraPreset> GetExtraPresets(string annoVersion)
        {
            var result = new List<ExtraPreset>();

            switch (annoVersion)
            {
                case Program.ANNO_VERSION_1404:
                    result.AddRange(getExtraPresetsForAnno1404());
                    break;
                case Program.ANNO_VERSION_2070:
                    result.AddRange(getExtraPresetsForAnno2070());
                    break;
                case Program.ANNO_VERSION_1800:
                    result.AddRange(getExtraPresetsForAnno1800());
                    break;
            }

            return result;
        }

        private static IEnumerable<ExtraPreset> getExtraPresetsForAnno1404()
        {
            var result = new List<ExtraPreset>();

            result.Add(new ExtraPreset { BuildBlockerX = 3, BuildBlockerZ = 2, Faction = "Production", Group = "Farm Fields", Header = "(A4) Anno 1404", IconFileName = "A4_icon_116_22.png", Identifier = "FarmField_3x2", InfluenceRadius = 0, InfluenceRange = 0, Template = "FarmFields", LocaEng = "(3x2) Farm field", LocaGer = "(3x2) Gemüseäcker", LocaPol = "(3x2) Pole", LocaRus = "(3x2) Поле" });
            result.Add(new ExtraPreset { BuildBlockerX = 3, BuildBlockerZ = 3, Faction = "Production", Group = "Farm Fields", Header = "(A4) Anno 1404", IconFileName = "A4_icon_116_22.png", Identifier = "FarmField_3x3", InfluenceRadius = 0, InfluenceRange = 0, Template = "FarmFields", LocaEng = "(3x3) Farm field", LocaGer = "(3x3) Gemüseäcker", LocaPol = "(3x3) Pole", LocaRus = "(3x3) Поле" });
            result.Add(new ExtraPreset { BuildBlockerX = 4, BuildBlockerZ = 3, Faction = "Production", Group = "Farm Fields", Header = "(A4) Anno 1404", IconFileName = "A4_icon_116_22.png", Identifier = "FarmField_4x3", InfluenceRadius = 0, InfluenceRange = 0, Template = "FarmFields", LocaEng = "(4x3) Farm field", LocaGer = "(4x3) Gemüseäcker", LocaPol = "(4x3) Pole", LocaRus = "(4x3) Поле" });
            result.Add(new ExtraPreset { BuildBlockerX = 4, BuildBlockerZ = 4, Faction = "Production", Group = "Farm Fields", Header = "(A4) Anno 1404", IconFileName = "A4_icon_116_22.png", Identifier = "FarmField_4x4", InfluenceRadius = 0, InfluenceRange = 0, Template = "FarmFields", LocaEng = "(4x4) Farm field", LocaGer = "(4x4) Gemüseäcker", LocaPol = "(4x4) Pole", LocaRus = "(4x4) Поле" });

            return result;
        }

        private static IEnumerable<ExtraPreset> getExtraPresetsForAnno2070()
        {
            var result = new List<ExtraPreset>();

            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 6, Faction = "Others", Group = "Black Smokers (Deep Sea)", Header = "(A5) Anno 2070", IconFileName = "icon_30_281.png", Identifier = "black_smoker_miner_gold_II", InfluenceRadius = 0, InfluenceRange = 0, Template = "FarmBuilding", LocaEng = "Gold Metal converter", LocaGer = "Metallkonverter Gold", LocaPol = "Konwerter warstw złotonośnych", LocaRus = "Конвертер золота" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 6, Faction = "Others", Group = "Black Smokers (Deep Sea)", Header = "(A5) Anno 2070", IconFileName = "icon_30_282.png", Identifier = "black_smoker_miner_copper_II", InfluenceRadius = 0, InfluenceRange = 0, Template = "FarmBuilding", LocaEng = "Copper Metal converter", LocaGer = "Metallkonverter Kupfer", LocaPol = "Konwerter warstw miedzionośnych", LocaRus = "Конвертер меди" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 6, Faction = "Others", Group = "Black Smokers (Deep Sea)", Header = "(A5) Anno 2070", IconFileName = "icon_30_283.png", Identifier = "black_smoker_miner_uranium_II", InfluenceRadius = 0, InfluenceRange = 0, Template = "FarmBuilding", LocaEng = "Uranium Metal converter", LocaGer = "Metallkonverter Uran", LocaPol = "Konwerter warstw bogatych w uran", LocaRus = "Конвертер урана" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 6, Faction = "Others", Group = "Black Smokers (Deep Sea)", Header = "(A5) Anno 2070", IconFileName = "icon_30_280.png", Identifier = "black_smoker_miner_iron_II", InfluenceRadius = 0, InfluenceRange = 0, Template = "FarmBuilding", LocaEng = "Iron Metal converter", LocaGer = "Metallkonverter Eisen", LocaPol = "Konwerter żelaza", LocaRus = "Конвертер железа" });

            return result;
        }

        private static IEnumerable<ExtraPreset> getExtraPresetsForAnno1800()
        {
            var result = new List<ExtraPreset>();

            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 5, Faction = "(2) Workers", Group = null, Header = "(A7) Anno 1800", IconFileName = "A7_warehouse.png", Identifier = "Logistic_02 (Warehouse I)", InfluenceRadius = 0, InfluenceRange = 0, Template = "Warehouse", LocaEng = "Small Warehouse", LocaGer = "Lagerhaus", LocaPol = "Mały magazyn", LocaRus = "Маленький склад" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 5, Faction = "(3) Artisans", Group = null, Header = "(A7) Anno 1800", IconFileName = "A7_warehouse.png", Identifier = "Logistic_02 (Warehouse I)", InfluenceRadius = 0, InfluenceRange = 0, Template = "Warehouse", LocaEng = "Small Warehouse", LocaGer = "Lagerhaus", LocaPol = "Mały magazyn", LocaRus = "Маленький склад" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 5, Faction = "(4) Engineers", Group = null, Header = "(A7) Anno 1800", IconFileName = "A7_warehouse.png", Identifier = "Logistic_02 (Warehouse I)", InfluenceRadius = 0, InfluenceRange = 0, Template = "Warehouse", LocaEng = "Small Warehouse", LocaGer = "Lagerhaus", LocaPol = "Mały magazyn", LocaRus = "Маленький склад" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 5, Faction = "(5) Investors", Group = null, Header = "(A7) Anno 1800", IconFileName = "A7_warehouse.png", Identifier = "Logistic_02 (Warehouse I)", InfluenceRadius = 0, InfluenceRange = 0, Template = "Warehouse", LocaEng = "Small Warehouse", LocaGer = "Lagerhaus", LocaPol = "Mały magazyn", LocaRus = "Маленький склад" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 5, Faction = "(7) Jornaleros", Group = null, Header = "(A7) Anno 1800", IconFileName = "A7_warehouse.png", Identifier = "Logistic_02 (Warehouse I)", InfluenceRadius = 0, InfluenceRange = 0, Template = "Warehouse", LocaEng = "Small Warehouse", LocaGer = "Lagerhaus", LocaPol = "Mały magazyn", LocaRus = "Маленький склад" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 5, Faction = "(8) Obreros", Group = null, Header = "(A7) Anno 1800", IconFileName = "A7_warehouse.png", Identifier = "Logistic_02 (Warehouse I)", InfluenceRadius = 0, InfluenceRange = 0, Template = "Warehouse", LocaEng = "Small Warehouse", LocaGer = "Lagerhaus", LocaPol = "Mały magazyn", LocaRus = "Маленький склад" });
            result.Add(new ExtraPreset { BuildBlockerX = 6, BuildBlockerZ = 4, Faction = "Attractiveness", Group = "Modules", Header = "(A7) Anno 1800", IconFileName = "A7_Zoo module.png", Identifier = "Culture_01_module", InfluenceRadius = 0, InfluenceRange = 0, Template = "CultureModule", LocaEng = "Zoo Module (6x4)", LocaGer = "Zoo-Modul (6x4)", LocaPol = "Moduł ZOO (6x4)", LocaRus = "Модуль зоопарка (6x4)" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 4, Faction = "Attractiveness", Group = "Modules", Header = "(A7) Anno 1800", IconFileName = "A7_Museum module.png", Identifier = "Culture_02_module", InfluenceRadius = 0, InfluenceRange = 0, Template = "CultureModule", LocaEng = "Museum Module (5x4)", LocaGer = "Museumsmodul (5x4)", LocaPol = "Moduł Muzeum (5x4)", LocaRus = "Модуль музея (5x4)" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "All Worlds", Group = "OrnamentalBuilding", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_system_1x1_44.png", Identifier = "Park_1x1_appletree", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding", LocaEng = "Apple Tree", LocaGer = "Apfelbaum", LocaPol = "Jabłoń", LocaRus = "Яблоня" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "All Worlds", Group = "OrnamentalBuilding", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_system_1x1_40.png", Identifier = "Park_1x1_elmtree", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding", LocaEng = "Elm Tree", LocaGer = "Ulme", LocaPol = "Wiąz", LocaRus = "Вяз" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "All Worlds", Group = "OrnamentalBuilding", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_system_1x1_39.png", Identifier = "Park_1x1_grownbush", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding", LocaEng = "Mature Shrubbery", LocaGer = "Großes Gebüsch", LocaPol = "Dojrzałe krzewy", LocaRus = "Кустарник" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "All Worlds", Group = "OrnamentalBuilding", Header = "(A7) Anno 1800", IconFileName = "A7_park_1x1_02.png", Identifier = "Park_1x1_poplar", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding", LocaEng = "Poplar", LocaGer = "Pappel", LocaPol = "Topola", LocaRus = "Тополь" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "All Worlds", Group = "OrnamentalBuilding", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_1x1_26.png", Identifier = "Park_1x1_bush", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding", LocaEng = "Shrubbery", LocaGer = "Gebüsch", LocaPol = "Krzewy", LocaRus = "Кустарник" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "All Worlds", Group = "OrnamentalBuilding", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_system_1x1_temperateforest.png", Identifier = "Park_1x1_temperateforest", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding", LocaEng = "Temperate Grove", LocaGer = "Laubbaum", LocaPol = "Zagajnik klimatu umiarkowanego", LocaRus = "Лиственная роща" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "All Worlds", Group = "OrnamentalBuilding", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_system_1x1_43.png", Identifier = "Park_1x1_tremblingaspen", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding", LocaEng = "Trembling Aspen", LocaGer = "Zitterpappel", LocaPol = "Topola osikowa", LocaRus = "Осина" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "All Worlds", Group = "OrnamentalBuilding", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_system_1x1_45.png", Identifier = "Park_1x1_wateringplace", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding", LocaEng = "Watering Hole", LocaGer = "Alte Tränke", LocaPol = "Wodopój", LocaRus = "Водопой" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "All Worlds", Group = "OrnamentalBuilding", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_system_1x1_46.png", Identifier = "Park_1x1_well", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding", LocaEng = "Well", LocaGer = "Brunnen", LocaPol = "Studnia", LocaRus = "Колодец" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "All Worlds", Group = "OrnamentalBuilding", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_system_1x1_38.png", Identifier = "Park_1x1_flowerbed", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding", LocaEng = "Flower Bed", LocaGer = "Blumenbeet", LocaPol = "Klomb", LocaRus = "Цветочная поляна" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "All Worlds", Group = "OrnamentalBuilding", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_system_1x1_36.png", Identifier = "Park_1x1_hedgegate", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding", LocaEng = "Entrance", LocaGer = "Eingang", LocaPol = "Wejście", LocaRus = "Вход" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "All Worlds", Group = "OrnamentalBuilding", Header = "(A7) Anno 1800", IconFileName = "A7_cultural_props_1x1_04.png", Identifier = "Culture_1x1_fencegate", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding", LocaEng = "Archway", LocaGer = "Torbogen", LocaPol = "Brama", LocaRus = "Арка" });
            result.Add(new ExtraPreset { BuildBlockerX = 2, BuildBlockerZ = 2, Faction = "All Worlds", Group = "OrnamentalBuilding", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_2x2_02.png", Identifier = "Park_2x2_manstatue", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding", LocaEng = "Memorial Garden", LocaGer = "Gedenkgarten", LocaPol = "Ogród pamięci", LocaRus = "Памятный сад" });
            result.Add(new ExtraPreset { BuildBlockerX = 3, BuildBlockerZ = 3, Faction = "All Worlds", Group = "OrnamentalBuilding", Header = "(A7) Anno 1800", IconFileName = "A7_park_props3x3_02.png", Identifier = "Park_3x3_fountain", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding", LocaEng = "Fountain Plaza", LocaGer = "Springbrunnenplatz", LocaPol = "Plac z fontanną", LocaRus = "Площадь с фонтанами" });
            result.Add(new ExtraPreset { BuildBlockerX = 22, BuildBlockerZ = 18, Faction = "Attractiveness", Group = null, Header = "(A7) Anno 1800", IconFileName = "A7_world_fair_2.png", Identifier = "Worlds_Fair_Foundation", InfluenceRadius = 0, InfluenceRange = 0, Template = "WorldsFairFoundation", LocaEng = "World's Fair (Foundation)", LocaGer = "Weltausstellung (Stiftung)", LocaPol = "Światowe Targi (Fundacja)", LocaRus = "Всемирная ярмарка (Фонд)" });

            return result;
        }
    }
}
