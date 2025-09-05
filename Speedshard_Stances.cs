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
    public override string Version => "2.1.0";
    public override string TargetVersion => "0.9.3.7";

    public override void PatchMod()
    {
        Msl.LoadGML("gml_Object_o_buff_stance_Create_0")
            .MatchAll()
            .InsertBelow(ModFiles, "gml_Object_o_buff_stance_Create_0.gml")
            .Save();

        Msl.AddNewEvent("o_buff_stance", ModFiles.GetCode("gml_Object_o_buff_stance_Other_15.gml"), EventType.Other, 15);
        Msl.AddNewEvent("o_buff_stance", ModFiles.GetCode("gml_Object_o_buff_stance_Other_10.gml"), EventType.Other, 10);

        Msl.LoadGML("gml_Object_o_buff_stance_Other_20")
            .MatchFrom("duration")
            .ReplaceBy("")
            .MatchFromUntil("stage > 1", "can_lose_stage")
            .ReplaceBy(@"
scr_restore_mp(owner, (1 * stage))
with(o_buff_stance)
{
    if (stage > 1)
    {
        stage -= 1;
    }
}
can_lose_stage = false
")
            .Save();

        Msl.LoadGML("gml_Object_o_skill_Other_17")
            .MatchFrom("if scr_stance_training(owner.id)")
            .InsertAbove(ModFiles, "gml_Object_o_skill_Other_17.gml")
            .Save();

        Msl.GetObject("o_b_defence_stance").ParentId = Msl.GetObject("o_buff_stance");

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
            "gml_Object_o_b_defence_stance_Other_15",
        };

        foreach (string stanceBonus in stancesBonus)
        {
            Msl.LoadGML(stanceBonus)
                .Apply(StancesBonusIterator)
                .Save();
        }

        // for hold the line
        Msl.LoadGML("gml_Object_o_buff_stance_Alarm_1")
            .MatchFrom("other.id")
            .ReplaceBy(@"
if (id != other.id && id.object_index != o_b_defence_stance && other.id.object_index != o_b_defence_stance)
")
            .Save();

        Msl.LoadGML("gml_Object_o_b_defence_stance_Other_14")
            .MatchFrom("duration")
            .ReplaceBy("")
            .Save();

        Msl.LoadGML("gml_Object_o_b_defence_stance_Other_13")
            .MatchFrom("stage -= 1")
            .ReplaceBy(@"
scr_restore_mp(owner, (1 * stage))
with(o_buff_stance)
{
    if (stage > 1)
    {
        stage -= 1;
    }
}")
            .MatchFrom("duration")
            .ReplaceBy("")
            .Save();

        Msl.LoadGML("gml_Object_o_b_defence_stance_Other_15")
            .MatchFrom("CTA")
            .InsertBelow(@"
if (scr_shield_get_weight() == ""Light"")
{
    ds_map_replace(other.data, ""CTA"", 10 * other.stage);
}
else
{
    ds_map_replace(other.data, ""CTA"", 7 * other.stage);
}
if (scr_shield_get_weight() == ""Heavy"")
{
    ds_map_replace(other.data, ""Damage_Returned"", 5 * other.stage);
}
")
            .Save();

        Msl.LoadGML("gml_Object_o_b_defence_stance_Alarm_2")
            .MatchFrom("scr_shield_get_weight()\nstage")
            .ReplaceBy("")
            .Save();

        Msl.LoadGML("gml_Object_o_skill_defensive_stance_Other_17")
            .MatchFrom("Light\nmaxKD")
            .ReplaceBy("")
            .Save();

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
            ("o_skill_defensive_stance", "o_b_defence_stance"),
        };

        foreach ((string skill, string buff) in buffNames)
        {
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

        // Localization
        Speedshard_Stances_Localization.DescriptionUpdate();
    }
    private static IEnumerable<string> StancesBonusIterator(IEnumerable<string> strings)
    {
        foreach (string str in strings)
        {
            if (str.Contains("ds_map_clear(other.data)"))
            {
                continue;
            }
            else if (str.Contains("ds_map_add"))
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
