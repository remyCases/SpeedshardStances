using System.Text.RegularExpressions;
using ModShardLauncher;

namespace Speedshard_Stances;

class DescriptionSkillsEffects
{
    public readonly string skill_id;
    readonly Dictionary<ModShardLauncher.Mods.ModLanguage, string> skill_desc;
    public readonly string effect_id;
    readonly Dictionary<ModShardLauncher.Mods.ModLanguage, string> effect_desc;

    public static DescriptionSkillsEffects Empty
    {
        get
        {
            return new DescriptionSkillsEffects(
                string.Empty,
                new Dictionary<ModShardLauncher.Mods.ModLanguage, string>(),
                string.Empty,
                new Dictionary<ModShardLauncher.Mods.ModLanguage, string>()
            );
        }
    }

    public DescriptionSkillsEffects(
        string skill_id,
        Dictionary<ModShardLauncher.Mods.ModLanguage, string> skill_desc,
        string effect_id,
        Dictionary<ModShardLauncher.Mods.ModLanguage, string> effect_desc
    )
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
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
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
"##Only one ~w~Stance~/~ effect (except for ~w~Hold the Line!~/~) can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"触发 ~lg~\\\"刀剑站姿\\\"~/~ 直到主动关闭或能量耗尽:" +
"##~lg~+5%~/~ 反击几率" +
"#~lg~+5%~/~ 格挡几率" +
"#~lg~+5%~/~ 闪躲几率" +
"#~lg~+8%~/~ 出血几率" +
"#~r~-1~/~ 精力恢复" +
"#~r~-5%~/~ 精力自动恢复" +
"##运用同一能力树的技能会令这个效果叠加1层 (最多叠到 ~w~四~/~ 层)。" +
"##刀剑普通击打会每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" +
"##~w~\\\"战术优势\\\"~/~ 将会移除每回合的精力损失。" +
"##同一时间只有一个 ~w~站姿~/~ 效果 (除开 ~w~寸步不让!~/~) 能够被触发。 触发和关闭 ~w~站姿~/~ 不消耗回合。" }
}
,

"o_b_fencer_stance",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
"Using the ability tree's skills grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic sword strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"运用同一能力树的技能会令这个效果叠加1层 (最多叠到 ~sy~四~/~ 层)。" +
"##刀剑普通击打会每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" }
}),

        new DescriptionSkillsEffects(
"Massacre",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
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
"##Only one ~w~Stance~/~ effect (except for ~w~Hold the Line!~/~) can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"触发 ~lg~\\\"大开杀戒\\\"~/~ 直到主动关闭或能量耗尽:" +
"##~lg~+5%~/~ 护甲穿透" +
"#~lg~+10%~/~ 肢体伤害" +
"#~lg~+5%~/~ 出血几率" +
"#~lg~+3%~/~ 暴击几率" +
"#~r~-1~/~ 精力恢复" +
"#~r~-5%~/~ 精力自动恢复" +
"##运用同一能力树的技能会令这个效果叠加1层 (最多叠到 ~w~四~/~ 层)。" +
"##单手斧普通击打每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" +
"##~w~\\\"战术优势\\\"~/~ 将会移除每回合的精力损失。" +
"##同一时间只有一个 ~w~站姿~/~ 效果 (除开 ~w~寸步不让!~/~) 能够被触发。 触发和关闭 ~w~站姿~/~ 不消耗回合。"}
},

"o_b_massacre",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
"Using the ability tree's skills grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic axe strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"运用同一能力树的技能会令这个效果叠加1层 (最多叠到 ~sy~四~/~ 层)。" +
"##单手斧普通击打每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" }
}),

        new DescriptionSkillsEffects(
"Hammer_and_Anvil",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
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
"##Only one ~w~Stance~/~ effect (except for ~w~Hold the Line!~/~) can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"触发 ~lg~\\\"锤与铁砧\\\"~/~ 直到主动关闭或能量耗尽:" +
"##~lg~-3%~/~ 失手几率" +
"#~lg~+25%~/~ 护甲破坏" +
"#~lg~+10%~/~ 击晕几率" +
"#~lg~+10%~/~ 破衡几率" +
"#~r~-1~/~ 精力恢复" +
"#~r~-5%~/~ 精力自动恢复" +
"##运用同一能力树的技能会令这个效果叠加1层 (最多叠到 ~w~四~/~ 层)。" +
"##单手棒槌普通击打每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" +
"##~w~\\\"战术优势\\\"~/~ 将会移除每回合的精力损失。" +
"##同一时间只有一个 ~w~站姿~/~ 效果 (除开 ~w~寸步不让!~/~) 能够被触发。 触发和关闭 ~w~站姿~/~ 不消耗回合。" }
},

"o_b_hammer_and_anvil",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
"Using the ability tree's skills grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic mace strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"运用同一能力树的技能会令这个效果叠加1层 (最多叠到 ~sy~四~/~ 层)。" +
"##单手棒槌普通击打每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" }
}),

        new DescriptionSkillsEffects(
"Painful_Stabs",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
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
"##Only one ~w~Stance~/~ effect (except for ~w~Hold the Line!~/~) can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"触发 ~lg~\"辣手利刃\"~/~ 直到主动关闭或能量耗尽:" +
"##~lg~+4%~/~ 暴击几率" +
"#~lg~+10%~/~ 暴击效果" +
"#~lg~+5%~/~ 兵器伤害" +
"#~lg~+12%~/~ 出血几率" +
"#~r~-1~/~ 精力恢复" +
"#~r~-5%~/~ 精力自动恢复" +
"##运用同一能力树的技能会令这个效果叠加1层 (最多叠到 ~w~四~/~ 层)。" +
"##匕首普通击打每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" +
"##~w~\\\"战术优势\\\"~/~ 将会移除每回合的精力损失。" +
"##同一时间只有一个 ~w~站姿~/~ 效果 (除开 ~w~寸步不让!~/~) 能够被触发。 触发和关闭 ~w~站姿~/~ 不消耗回合。" }
},

"o_b_painful_stabs",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
"Using the ability tree's skills grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic dagger strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"运用同一能力树的技能会令这个效果叠加1层 (最多叠到 ~sy~四~/~ 层)。" +
"##匕首普通击打每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" }
}),

        new DescriptionSkillsEffects(
"Unwavering_Stance",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
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
"##Only one ~w~Stance~/~ effect (except for ~w~Hold the Line!~/~) can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"触发 ~lg~\"不动不摇\"~/~ 直到主动关闭或能量耗尽:" +
"##~lg~+10%~/~ 魔法抗性" +
"#~lg~+10%~/~ 自然抗性" +
"#~lg~+5%~/~ 反击几率" +
"#~lg~+10%~/~ 格挡几率" +
"#~lg~+10%~/~ 格挡力量上限" +
"#~lg~+10%~/~ 格挡力量恢复" +
"#每 ~w~第三次~/~ 击打， ~lg~+100%~/~ 击退几率。" +
"#~r~-1~/~ 精力恢复" +
"#~r~-5%~/~ 精力自动恢复" +
"##运用同一能力树的技能会令这个效果叠加1层 (最多叠到 ~w~四~/~ 层)。" +
"##长杖普通击打每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" +
"##~w~\\\"战术优势\\\"~/~ 将会移除每回合的精力损失。" +
"##同一时间只有一个 ~w~站姿~/~ 效果 (除开 ~w~寸步不让!~/~) 能够被触发。 触发和关闭 ~w~站姿~/~ 不消耗回合。" }
},

"o_b_unwavering_stance",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
"Using the ability tree's skills grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic staff strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"运用同一能力树的技能会令这个效果叠加1层 (最多叠到 ~sy~四~/~ 层)。" +
"##长杖普通击打每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" }
}),

        new DescriptionSkillsEffects(
"Suppression",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
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
"##Only one ~w~Stance~/~ effect (except for ~w~Hold the Line!~/~) can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"触发 ~lg~\"压制\"~/~ 直到主动关闭或能量耗尽:" +
"##~lg~+5%~/~ 限制移动几率" +
"#~lg~+10%~/~ 击退几率" +
"#~lg~+10%~/~ 出血几率" +
"#~lg~-5%~/~ 能力冷却时间" +
"#~lg~-5%~/~ 技能精力消耗" +
"#~r~-1~/~ 精力恢复" +
"#~r~-5%~/~ 精力自动恢复" +
"##运用同一能力树的技能 (除开 ~w~\"瞄准\"~/~) 令这个效果叠加1层 (最多叠到 ~w~四~/~ 层)。" +
"##普通射击每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" +
"##~w~\\\"战术优势\\\"~/~ 将会移除每回合的精力损失。" +
"##同一时间只有一个 ~w~站姿~/~ 效果 (除开 ~w~寸步不让!~/~) 能够被触发。 触发和关闭 ~w~站姿~/~ 不消耗回合。" }
},

"o_b_suppression",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
"Using the ability tree's skills (except ~sy~Taking Aim~/~) grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic shots restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"运用同一能力树的技能 (除开 ~sy~瞄准~/~) 令这个效果叠加1层 (最多叠到 ~sy~四~/~ 层)。" +
"##普通射击每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" }
}),

        new DescriptionSkillsEffects(
"Pikemans_Stance",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
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
"##Only one ~w~Stance~/~ effect (except for ~w~Hold the Line!~/~) can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"触发 ~lg~\"枪兵站姿\"~/~ 直到主动关闭或能量耗尽:" +
"##~lg~+5%~/~ 准度" +
"#~lg~+5%~/~ 出血几率" +
"#~lg~+15%~/~ 击退几率" +
"#~lg~+8%~/~ 限制移动几率" +
"#~r~-1~/~ 精力恢复" +
"#~r~-5%~/~ 精力自动恢复" +
"##运用同一能力树的技能会令这个效果叠加1层 (最多叠到 ~w~四~/~ 层)。" +
"##长杆刃器普通击打每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" +
"##~w~\\\"战术优势\\\"~/~ 将会移除每回合的精力损失。" +
"##同一时间只有一个 ~w~站姿~/~ 效果 (除开 ~w~寸步不让!~/~) 能够被触发。 触发和关闭 ~w~站姿~/~ 不消耗回合。" }
},

"o_b_pikemanstance",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
"Using the ability tree's skills grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic spear strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"运用同一能力树的技能会令这个效果叠加1层 (最多叠到 ~sy~四~/~ 层)。" +
"##长杆刃器普通击打每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" }
}),

        new DescriptionSkillsEffects(
"Steel_Feast",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
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
"##Only one ~w~Stance~/~ effect (except for ~w~Hold the Line!~/~) can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"触发 ~lg~\"刀剑无情\"~/~ 直到主动关闭或能量耗尽:" +
"##~lg~+5%~/~ 反击几率" +
"#~lg~-4%~/~ 失手几率" +
"#~lg~+5%~/~ 准度" +
"#~lg~+2.5%~/~ 暴击几率" +
"#每 ~w~第三次~/~ 击打， ~lg~+100%~/~ 破衡几率。" +
"#~r~-1~/~ 精力恢复" +
"#~r~-5%~/~ 精力自动恢复" +
"##运用同一能力树的技能会令这个效果叠加1层 (最多叠到 ~w~四~/~ 层)。" +
"##双手刀剑普通击打每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" +
"##~w~\\\"战术优势\\\"~/~ 将会移除每回合的精力损失。" +
"##同一时间只有一个 ~w~站姿~/~ 效果 (除开 ~w~寸步不让!~/~) 能够被触发。 触发和关闭 ~w~站姿~/~ 不消耗回合。" }
},

"o_b_steel_feast",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
"Using the ability tree's skills grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic two-handed sword strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"运用同一能力树的技能会令这个效果叠加1层 (最多叠到 ~sy~四~/~ 层)。" +
"##双手刀剑普通击打每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" }
}),

        new DescriptionSkillsEffects(
"Mayhem",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
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
"##Only one ~w~Stance~/~ effect (except for ~w~Hold the Line!~/~) can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn." +
"##If affected by ~lg~\"Mighty Swing\"~/~, using the skill delivers a strike to a random adjacent enemy."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"触发 ~lg~\"大杀四方\"~/~ 直到主动关闭或能量耗尽:" +
"##~lg~+3%~/~ 暴击几率" +
"#~lg~+10%~/~ 击退几率" +
"#~lg~+10%~/~ 护甲穿透" +
"#~lg~+15%~/~ 破衡几率" +
"#每 ~w~第三次~/~ 击打， ~lg~+100%~/~ 击晕几率。" +
"#~r~-1~/~ 精力恢复" +
"#~r~-5%~/~ 精力自动恢复" +
"##运用同一能力树的技能会令这个效果叠加1层 (最多叠到 ~w~四~/~ 层)。" +
"##双手锤棒普通击打每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" +
"##~w~\\\"战术优势\\\"~/~ 将会移除每回合的精力损失。" +
"##同一时间只有一个 ~w~站姿~/~ 效果 (除开 ~w~寸步不让!~/~) 能够被触发。 触发和关闭 ~w~站姿~/~ 不消耗回合。" +
"##~lg~\"无坚不摧\"~/~ 生效期间, 运用这个技能会随机击打一个邻近敌人。" }
},

"o_b_carnage",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
"Using the ability tree's skills grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic two-handed mace strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)"},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"运用同一能力树的技能会令这个效果叠加1层 (最多叠到 ~sy~四~/~ 层)。" +
"##双手锤棒普通击打每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)" }
}),

        new DescriptionSkillsEffects(
"Rampage",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
"Activates ~lg~\"Rampage\"~/~ until deactivated or running out of Energy:" +
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
"##Only one ~w~Stance~/~ effect (except for ~w~Hold the Line!~/~) can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"触发 ~lg~\"运斤成风\"~/~ 直到主动关闭或能量耗尽:" +
"##~lg~-10%~/~ 技能精力消耗" +
"#~lg~+4%~/~ 暴击几率" +
"#~lg~+15%~/~ 出血几率" +
"#~lg~-3%~/~ 失手几率" +
"#每 ~w~第三次~/~ 击打， 会造成额外伤害，额外的伤害等于目标生命上限的 ~r~15%~/~ (但不会超过 ~w~/*Max_HP_Limit*/~/~)。" +
"#~r~-1~/~ 精力恢复" +
"#~r~-5%~/~ 精力自动恢复" +
"##运用同一能力树的技能会令这个效果叠加1层 (最多叠到 ~w~四~/~ 层)。" +
"##双手斧普通击打每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" +
"##~w~\\\"战术优势\\\"~/~ 将会移除每回合的精力损失。" +
"##同一时间只有一个 ~w~站姿~/~ 效果 (除开 ~w~寸步不让!~/~) 能够被触发。 触发和关闭 ~w~站姿~/~ 不消耗回合。" }
},

"o_b_rampage",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
"Using the ability tree's skills grants an extra stack of the effect (up to ~sy~IV~/~ stacks)." +
"##Basic two-handed axe strikes restores ~lg~1~/~ Energy by stacks but reduce its number of stacks (no more than once per turn)."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"运用同一能力树的技能会令这个效果叠加1层 (最多叠到 ~sy~四~/~ 层)。" +
"##双手斧普通击打每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" }
}),

        new DescriptionSkillsEffects(
"Defensive_Stance",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
"Activates ~lg~\"Hold the Line!\"~/~ until deactivated or running out of Energy:" +
"##~lg~-5%~/~ Damage Taken" +
"#~lg~+5%~/~ Block Power Recovery" +
"#~lg~+7%~/~ Counter Chance" +
"#~lg~+10%~/~ Move Resistance" +
"#~lg~+10%~/~ Control Resistance" +
"#~r~-1~/~ Energy Replenishment" +
"#~r~-5%~/~ Energy Restoration" +
"##Using the ability tree's skills grants ~lg~2~/~ stacks of the effect (up to ~w~IV~/~)." +
"##Each received hit restores ~lg~1~/~ Energy by stacks but reduces its number of stacks (no more than once per turn)." +
"##If equipped with a ~w~light shield~/~, adds ~lg~+3%~/~ Counter Chance by stacks (up to ~lg~+10%~/~)." +
"##If equipped with a ~w~heavy shield~/~, adds ~lg~+5%~/~ Damage Reflection by stacks." +
"##~w~\\\"Tactical Advantage\\\"~/~ removes the Energy losts each turn." +
"##Only one ~w~Stance~/~ effect (except for ~w~Hold the Line!~/~) can be active at a time. Activating and deactivating a ~w~Stance~/~ does not cost a turn."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"触发 ~lg~\"寸步不让!\"~/~ 直到主动关闭或能量耗尽:" +
"##~lg~-5%~/~ 所受伤害" +
"#~lg~+5%~/~ 格挡力量恢复" +
"#~lg~+7%~/~ 反击几率" +
"#~lg~+10%~/~ 位移抗性" +
"#~lg~+10%~/~ 控制抗性" +
"#~r~-1~/~ 精力恢复" +
"#~r~-5%~/~ 精力自动恢复" +
"##运用同一能力树的技能会令这个效果叠加 ~lg~2~/~ 层 (最多叠到 ~w~IV~/~ 层)." +
"##每次被命中每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" +
"##如果所用盾牌为 ~w~轻盾~/~, 每层 ~lg~+3%~/~ 反击几率(最多叠到 ~lg~+10%~/~)。" +
"##如果所用盾牌为 ~w~重盾~/~, 每层 ~lg~+5%~/~ 反伤。" +
"##~w~\\\"战术优势\\\"~/~ 将会移除每回合的精力损失。" +
"##同一时间只有一个 ~w~站姿~/~ 效果 (除开 ~w~寸步不让!~/~) 能够被触发。 触发和关闭 ~w~站姿~/~ 不消耗回合。" }
},

"o_b_defence_stance",
new Dictionary<ModShardLauncher.Mods.ModLanguage, string>() {
    { ModShardLauncher.Mods.ModLanguage.English,
"##Using the ability tree's skills grants ~lg~2~/~ stacks of the effect (up to ~w~IV~/~)." +
"##Each received hit restores ~lg~1~/~ Energy by stacks but reduces its number of stacks (no more than once per turn)."},
    { ModShardLauncher.Mods.ModLanguage.Chinese,
"##运用同一能力树的技能会令这个效果叠加 ~lg~2~/~ 层 (做多叠到 ~w~IV~/~ 层)." +
"##每次被命中每层恢复 ~lg~1~/~ 点精力， 但是会令效果层数减少 (每个回合最多一次)。" }
})
    };

    public static void DescriptionUpdate()
    {
        Msl.LoadAssemblyAsString("gml_GlobalScript_table_skills")
            .Apply(SkillsDescriptionIterator)
            .Save();

        Msl.LoadAssemblyAsString("gml_GlobalScript_table_effects")
            .Apply(EffectsDescriptionIterator)
            .Save();

        Msl.LoadAssemblyAsString("gml_GlobalScript_table_skills_stats")
            .Apply(SkillsStatsIterator)
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
            throw new InvalidOperationException("Could not locate the description skills table.");
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
            throw new InvalidOperationException("Could not locate the description skills table.");
    }
    // change defensive_stance from a maneuver to a stance
    private static IEnumerable<string> SkillsStatsIterator(IEnumerable<string> input)
    {
        bool found = false;
        foreach (string item in input)
        {
            if (!found && item.Contains("\"Defensive_Stance"))
            {
                found = true;
                yield return "push.s \"Defensive_Stance;o_b_defence_stance;No Target;1;12;12;0;10;0;0;0;normal;;skill;0;;shield;0;;weapon;0;0;;1;;;;\"";
            }
            else
            {
                yield return item;
            }
        }

        if (!found)
            throw new InvalidOperationException("Could not locate the skill stats for Defensive_Stance.");
    }
}