using ModShardLauncher;

namespace Speedshard_Stances;

class DescriptionSkillsEffects
{
    public readonly string skill_id;
    readonly string skill_desc;
    public readonly string effect_id;
    readonly string effect_desc;

    public static DescriptionSkillsEffects Empty
    {
        get
        {
            return new DescriptionSkillsEffects(string.Empty, string.Empty, string.Empty, string.Empty);
        }
    }

    public DescriptionSkillsEffects(string skill_id, string skill_desc, string effect_id, string effect_desc)
    {
        this.skill_id = skill_id;
        this.skill_desc = skill_desc;
        this.effect_id = effect_id;
        this.effect_desc = effect_desc;
    }
    public string GenerateSkillDescription()
    {
        Dictionary<ModShardLauncher.Mods.ModLanguage, string> new_desc_localization = Localization.SetDictionary(skill_desc);
        return $"{skill_id};{string.Concat(new_desc_localization.Values.Select(x => @$"{x};"))}";
    }
    public string GenerateEffectDescription()
    {
        Dictionary<ModShardLauncher.Mods.ModLanguage, string> new_desc_localization = Localization.SetDictionary(effect_desc);
        return $"{effect_id};{string.Concat(new_desc_localization.Values.Select(x => @$"{x};"))}";
    }
}
static public class Speedshard_Stances_Localization
{
    static readonly List<DescriptionSkillsEffects> new_desc_en = new() {
        new DescriptionSkillsEffects(
"Fencer_Stance",
"Activates ~lg~\\\"Fencer Stance\\\"~/~ until deactivated or running out of Energy:" +
"##~lg~+5%~/~ Counter Chance" +
"#~lg~+5%~/~ Block Chance" +
"#~lg~+5%~/~ Dodge Chance" +
"#~lg~+8%~/~ Bleed Chance" +
"#~r~-1~/~ Energy Replenishment" +
"#~r~-5%~/~ Energy Restoration" +
"##Using the ability tree's skills grants an extra stack of the effect (up to ~w~IV~/~)." +
"##Basic sword strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)." +
"##~w~\\\"Tactical Advantage\\\"~/~ removes the Energy losts each turn." +
"##Only one ~w~Stance~/~ effect can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn.",

"o_b_fencer_stance",
"Using the ability tree's skills grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic sword strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)."),

        new DescriptionSkillsEffects(
"Massacre",
"Activates ~lg~\\\"Massacre\\\"~/~ until deactivated or running out of Energy:" +
"##~lg~+5%~/~ Armor Penetration" +
"#~lg~+10%~/~ Bodypart Damage" +
"#~lg~+5%~/~ Bleed Chance" +
"#~lg~+3%~/~ Crit Chance" +
"#~r~-1~/~ Energy Replenishment" +
"#~r~-5%~/~ Energy Restoration" +
"##Using the ability tree's skills grants an extra stack of the effect (up to ~w~IV~/~)." +
"##Basic axe strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)." +
"##~w~\\\"Tactical Advantage\\\"~/~ removes the Energy losts each turn." +
"##Only one ~w~Stance~/~ effect can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn.",

"o_b_massacre",
"Using the ability tree's skills grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic axe strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn).") ,

        new DescriptionSkillsEffects(
"Hammer_and_Anvil",
"Activates ~lg~\\\"Hammer and Anvil\\\"~/~ until deactivated or running out of Energy:" +
"##~lg~-3%~/~ Fumble Chance" +
"#~lg~+25%~/~ Armor Damage" +
"#~lg~+10%~/~ Daze Chance" +
"#~lg~+10%~/~ Stagger Chance" +
"#~r~-1~/~ Energy Replenishment" +
"#~r~-5%~/~ Energy Restoration" +
"##Using the ability tree's skills grants an extra stack of the effect (up to ~w~IV~/~)." +
"##Basic mace strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)." +
"##~w~\\\"Tactical Advantage\\\"~/~ removes the Energy losts each turn." +
"##Only one ~w~Stance~/~ effect can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn.",

"o_b_hammer_and_anvil",
"Using the ability tree's skills grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic mace strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)."),

        new DescriptionSkillsEffects(
"Painful_Stabs",
"Activates ~lg~\"Painful Stabs\"~/~ until deactivated or running out of Energy:" +
"##~lg~+4%~/~ Crit Chance" +
"#~lg~+10%~/~ Crit Efficiency" +
"#~lg~+5%~/~ Weapon Damage" +
"#~lg~+12%~/~ Bleed Chance" +
"#~r~-1~/~ Energy Replenishment" +
"#~r~-5%~/~ Energy Restoration" +
"##Using the ability tree's skills grants an extra stack of the effect (up to ~w~IV~/~)." +
"##Basic dagger strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)." +
"##~w~\\\"Tactical Advantage\\\"~/~ removes the Energy losts each turn." +
"##Only one ~w~Stance~/~ effect can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn.",

"o_b_painful_stabs",
"Using the ability tree's skills grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic dagger strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)."),

        new DescriptionSkillsEffects(
"Unwavering_Stance",
"Activates ~lg~\"Unwavering Stance\"~/~ until deactivated or running out of Energy:" +
"##~lg~+10%~/~ Magic Resistance" +
"#~lg~+10%~/~ Nature Resistance" +
"#~lg~+5%~/~ Counter Chance" +
"#~lg~+10%~/~ Block Chance" +
"#~lg~+10%~/~ Max Block Power" +
"#~lg~+10%~/~ Block Power Recovery" +
"#Grants ~lg~+100%~/~ Knockback Chance to every ~w~third~/~ strike." +
"#~r~-1~/~ Energy Replenishment" +
"#~r~-5%~/~ Energy Restoration" +
"##Using the ability tree's skills grants an extra stack of the effect (up to ~w~IV~/~)." +
"##Basic staff strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)." +
"##~w~\\\"Tactical Advantage\\\"~/~ removes the Energy losts each turn." +
"##Only one ~w~Stance~/~ effect can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn.",

"o_b_unwavering_stance",
"Using the ability tree's skills grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic staff strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)."),

        new DescriptionSkillsEffects(
"Suppression",
"Activates ~lg~\"Suppression\"~/~ until deactivated or running out of Energy:" +
"##~lg~+5%~/~ Immobilization Chance" +
"#~lg~+10%~/~ Knockback Chance" +
"#~lg~+10%~/~ Bleed Chance" +
"#~lg~-5%~/~ Cooldowns Duration" +
"#~lg~-5%~/~ Skills Energy Cost" +
"#~r~-1~/~ Energy Replenishment" +
"#~r~-5%~/~ Energy Restoration" +
"##Using the ability tree's skills (except ~w~\"Taking Aim\"~/~) grants an extra stack of the effect (up to ~w~IV~/~)." +
"##Basic shots restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)." +
"##~w~\\\"Tactical Advantage\\\"~/~ removes the Energy losts each turn." +
"##Only one ~w~Stance~/~ effect can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn.",

"o_b_suppression",
"Using the ability tree's skills (except ~sy~Taking Aim~/~) grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic shots restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)."),

        new DescriptionSkillsEffects(
"Pikemans_Stance",
"Activates ~lg~\"Pikeman Stance\"~/~ until deactivated or running out of Energy:" +
"##~lg~+5%~/~ Accuracy" +
"#~lg~+5%~/~ Bleed Chance" +
"#~lg~+15%~/~ Knockback Chance" +
"#~lg~+8%~/~ Immobilization Chance" +
"#~r~-1~/~ Energy Replenishment" +
"#~r~-5%~/~ Energy Restoration" +
"##Using the ability tree's skills grants an extra stack of the effect (up to ~w~IV~/~)." +
"##Basic spear strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)." +
"##~w~\\\"Tactical Advantage\\\"~/~ removes the Energy losts each turn." +
"##Only one ~w~Stance~/~ effect can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn.",

"o_b_pikemanstance",
"Using the ability tree's skills grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic spear strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)."),

        new DescriptionSkillsEffects(
"Steel_Feast",
"Activates ~lg~\"Feast of Steel\"~/~ until deactivated or running out of Energy:" +
"##~lg~+5%~/~ Counter Chance" +
"#~lg~-4%~/~ Fumble Chance" +
"#~lg~+5%~/~ Accuracy" +
"#~lg~+2.5%~/~ Crit Chance" +
"#Grants ~lg~+100%~/~ Stagger Chance to every ~w~third~/~ strike." +
"#~r~-1~/~ Energy Replenishment" +
"#~r~-5%~/~ Energy Restoration" +
"##Using the ability tree's skills grants an extra stack of the effect (up to ~w~IV~/~)." +
"##Basic two-handed sword strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)." +
"##~w~\\\"Tactical Advantage\\\"~/~ removes the Energy losts each turn." +
"##Only one ~w~Stance~/~ effect can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn.",

"o_b_steel_feast",
"Using the ability tree's skills grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic two-handed sword strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)."),

        new DescriptionSkillsEffects(
"Mayhem",
"Activates ~lg~\"Striker Stance\"~/~ until deactivated or running out of Energy:" +
"##~lg~+3%~/~ Crit Chance" +
"#~lg~+10%~/~ Knockback Chance" +
"#~lg~+10%~/~ Armor Penetration" +
"#~lg~+15%~/~ Stagger Chance" +
"#Grants ~lg~+100%~/~ Daze Chance to every ~w~third~/~ strike." +
"#~r~-1~/~ Energy Replenishment" +
"#~r~-5%~/~ Energy Restoration" +
"##Using the ability tree's skills grants an extra stack of the effect (up to ~w~IV~/~)." +
"##Basic two-handed mace strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)." +
"##~w~\\\"Tactical Advantage\\\"~/~ removes the Energy losts each turn." +
"##Only one ~w~Stance~/~ effect can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn." +
"##If affected by ~lg~\"Mighty Swing\"~/~, using the skill delivers a strike to a random adjacent enemy.",

"o_b_carnage",
"Using the ability tree's skills grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic two-handed mace strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)"),

        new DescriptionSkillsEffects(
"Rampage",
"Activates ~lg~\"Rampage\"~/~ for ~w~10~/~ turns:" +
"##~lg~-10%~/~ Skills Energy Cost" +
"#~lg~+4%~/~ Crit Chance" +
"#~lg~+15%~/~ Bleed Chance" +
"#~lg~-3%~/~ Fumble Chance" +
"#Every ~w~third~/~ strike deals additional damage equal to ~r~15%~/~ of the target's Max Health (but no more than ~w~/*Max_HP_Limit*/~/~)." +
"#~r~-1~/~ Energy Replenishment" +
"#~r~-5%~/~ Energy Restoration" +
"##Using the ability tree's skills grants an extra stack of the effect (up to ~w~IV~/~)." +
"##Basic two-handed axe strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)." +
"##~w~\\\"Tactical Advantage\\\"~/~ removes the Energy losts each turn." +
"##Only one ~w~Stance~/~ effect can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn.",

"o_b_rampage",
"Using the ability tree's skills grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic two-handed axe strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)."),

    };

    public static void DescriptionUpdate()
    {
        Msl.LoadAssemblyAsString("gml_GlobalScript_table_skills")
            .Apply(SkillsDescriptionIterator)
            .Save();

        Msl.LoadAssemblyAsString("gml_GlobalScript_table_effects")
            .Apply(EffectsDescriptionIterator)
            .Save();
    }
    private static bool ContainsAnySkill(this string haystack, out DescriptionSkillsEffects out_desc)
    {
        foreach (DescriptionSkillsEffects desc in new_desc_en)
        {
            if (haystack.Contains($"push.s \"{desc.skill_id}"))
            {
                out_desc = desc;
                return true;
            }
        }

        out_desc = DescriptionSkillsEffects.Empty;
        return false;
    }
    private static bool ContainsAnyEffects(this string haystack, out DescriptionSkillsEffects out_desc)
    {
        foreach (DescriptionSkillsEffects desc in new_desc_en)
        {
            if (haystack.Contains($"push.s \"{desc.effect_id}"))
            {
                out_desc = desc;
                return true;
            }
        }

        out_desc = DescriptionSkillsEffects.Empty;
        return false;
    }
    private static IEnumerable<string> SkillsDescriptionIterator(IEnumerable<string> input)
    {
        bool in_desc = false;
        Dictionary<string, bool> modif_done = new();
        foreach (string id in new_desc_en.Select(x => x.skill_id))
        {
            modif_done.Add(id, false);
        }

        foreach (string item in input)
        {
            if (!in_desc && item.Contains("\";skill_desc_end")) // will happen only once
            {
                in_desc = true;
                yield return item;
            }
            else if (in_desc && item.ContainsAnySkill(out DescriptionSkillsEffects desc) && !modif_done[desc.skill_id]) // will happen only once by id
            {
                modif_done[desc.skill_id] = true;
                yield return $"push.s \"{desc.GenerateSkillDescription()}\"";
            }
            else
            {
                yield return item;
            }
        }

        if (!modif_done.All(x => x.Value))
            throw new InvalidOperationException(
                string.Format("No modification was made, {0} were not found in the description skills table.",
                string.Join(", ", modif_done.Where(x => !x.Value).Select(x => x.Key))));
        if (!in_desc)
            throw new InvalidOperationException("Could not located the description skills table.");
    }
    private static IEnumerable<string> EffectsDescriptionIterator(IEnumerable<string> input)
    {
        bool in_desc = false;
        Dictionary<string, bool> modif_done = new();
        foreach (string id in new_desc_en.Select(x => x.effect_id))
        {
            modif_done.Add(id, false);
        }

        foreach (string item in input)
        {
            if (!in_desc && item.Contains("\";buff_desc_end")) // will happen only once
            {
                in_desc = true;
                yield return item;
            }
            else if (in_desc && item.ContainsAnyEffects(out DescriptionSkillsEffects desc) && !modif_done[desc.effect_id]) // will happen only once by id
            {
                modif_done[desc.effect_id] = true;
                yield return $"push.s \"{desc.GenerateEffectDescription()}\"";
            }
            else
            {
                yield return item;
            }
        }

        if (!modif_done.All(x => x.Value))
            throw new InvalidOperationException(
                string.Format("No modification was made, {0} were not found in the description skills table.",
                string.Join(", ", modif_done.Where(x => !x.Value).Select(x => x.Key))));
        if (!in_desc)
            throw new InvalidOperationException("Could not located the description skills table.");
    }
}