// Copyright (C) 2024 Rémy Cases
// See LICENSE file for extended copyright information.
// This file is part of the Speedshard repository from https://github.com/remyCases/SpeedshardStances.

using ModShardLauncher;
using ModShardLauncher.Mods;
using UndertaleModLib.Models;

namespace Speedshard_Stances;
public class SpeedshardStances : Mod
{
    public override string Author => "zizani";
    public override string Name => "Speedshard - Stances";
    public override string Description => "A rework for Stances";
    public override string Version => "1.0.2";
    public override string TargetVersion => "0.8.2.10";

    public override void PatchMod()
    {
        Msl.LoadGML("gml_Object_o_buff_stance_Create_0")
            .MatchAll()
            .InsertBelow(ModFiles, "gml_Object_o_buff_stance_Create_0.gml")
            .Save();

        Msl.AddNewEvent("o_buff_stance", ModFiles.GetCode("gml_Object_o_buff_stance_Other_15.gml"), EventType.Other, 15);
        Msl.AddNewEvent("o_buff_stance", ModFiles.GetCode("gml_Object_o_buff_stance_Other_10.gml"), EventType.Other, 10);

        Msl.LoadGML("gml_Object_o_buff_stance_Other_20")
            .MatchFrom("duration\nstage")
            .ReplaceBy(ModFiles, "gml_Object_o_buff_stance_Other_20.gml")
            .Save();

        Msl.LoadGML("gml_Object_o_skill_Other_17")
            .MatchFromUntil("if scr_stance_training(owner.id)", "}\n}")
            .ReplaceBy(ModFiles, "gml_Object_o_skill_Other_17.gml")
            .Save();

        string[] stancesBonus = {
            "gml_Object_o_b_fencer_stance_Other_15",
            "gml_Object_o_b_massacre_Other_15",
            "gml_Object_o_b_hammer_and_anvil_Other_15",
            "gml_Object_o_b_painful_stabs_Other_15",
            "gml_Object_o_b_unwavering_stance_Other_15",
            "gml_Object_o_b_suppression_Other_15",
            "gml_Object_o_b_pikemanstance_Other_15",
            "gml_Object_o_b_steel_feast_Other_15",
            "gml_Object_o_b_carnage_Other_15",
            "gml_Object_o_b_rampage_Other_15",
        };

        foreach (string stanceBonus in stancesBonus)
        {
            Msl.LoadGML(stanceBonus)
                .MatchFrom("ds_map_clear(other.data)")
                .Remove()
                .Apply(StancesBonusIterator)
                .Save();
        }

        Msl.LoadAssemblyAsString("gml_Object_o_skill_Create_0")
            .MatchFrom("main_spell")
            .InsertBelow("pushi.e 1\npop.v.b self.cost_turn")
            .Save();

        Msl.LoadGML("gml_Object_o_skill_Alarm_1")
            .MatchFrom("scr_allturn()")
            .ReplaceBy(ModFiles, "gml_Object_o_skill_Alarm_1.gml")
            .Save();

        (string, string)[] buffNames = {
            ("o_skill_fencer_stance", "o_b_fencer_stance"),
            ("o_skill_massacre", "o_b_massacre"),
            ("o_skill_hammer_and_anvil", "o_b_hammer_and_anvil"),
            ("o_skill_painful_stabs", "o_b_painful_stabs"),
            ("o_skill_unwavering_stance", "o_b_unwavering_stance"),
            ("o_skill_suppression", "o_b_suppression"),
            ("o_skill_pikemans_stance", "o_b_pikemanstance"),
            ("o_skill_steel_feast", "o_b_steel_feast"),
            ("o_skill_mayhem", "o_b_carnage"),
            ("o_skill_rampage", "o_b_rampage"),
        };
        
        foreach ((string skill, string buff) in buffNames)
        {
            #nullable enable
            UndertaleGameObject.Event? ev = Msl.GetObject(skill).Events[(int)EventType.Other].FirstOrDefault(x => x.EventSubtype == 13);
            if (ev == null)
            {
                string eventCode = string.Format(@ModFiles.GetCode("gml_Object_o_skill__Other_13.gml"), buff, "event_inherited()");
                Msl.AddNewEvent(skill, eventCode, EventType.Other, 13);
            }
            else
            {
                string eventName = Msl.EventName(skill, EventType.Other, 13);
                string oldCode = Msl.GetStringGMLFromFile(eventName);
                string eventCode = string.Format(@ModFiles.GetCode("gml_Object_o_skill__Other_13.gml"), buff, oldCode);
                Msl.LoadGML(eventName)
                    .MatchAll()
                    .ReplaceBy(eventCode)
                    .Save();
            }
        }
    }
    private static IEnumerable<string> StancesBonusIterator(IEnumerable<string> strings)
    {
        foreach (string str in strings)
        {
            if (str.Contains("ds_map_add"))
            {
                yield return str.Replace("ds_map_add", "ds_map_replace");
            }
            else
            {
                yield return str;
            }
        }
    }
}
