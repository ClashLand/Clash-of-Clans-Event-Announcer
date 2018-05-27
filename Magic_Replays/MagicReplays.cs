using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace event_announcer.Magic_Replays
{
    public partial class MagicReplays
    {
        [JsonProperty("level")]
        public Level Level { get; set; }

        [JsonProperty("attacker")]
        public Attacker Attacker { get; set; }

        [JsonProperty("defender")]
        public Attacker Defender { get; set; }

        [JsonProperty("end_tick")]
        public long EndTick { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("cmd")]
        public Cmd[] Cmd { get; set; }

        [JsonProperty("calendar")]
        public Calendar Calendar { get; set; }

        [JsonProperty("globals")]
        public Globals Globals { get; set; }

        [JsonProperty("prep_skip")]
        public long PrepSkip { get; set; }
    }

    public partial class Attacker
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alliance_name")]
        public string AllianceName { get; set; }

        [JsonProperty("badge_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? BadgeId { get; set; }

        [JsonProperty("alliance_exp_level", NullValueHandling = NullValueHandling.Ignore)]
        public long? AllianceExpLevel { get; set; }

        [JsonProperty("league_type")]
        public long LeagueType { get; set; }

        [JsonProperty("avatar_id_high")]
        public long AvatarIdHigh { get; set; }

        [JsonProperty("avatar_id_low")]
        public long AvatarIdLow { get; set; }

        [JsonProperty("units")]
        public HeroHealth[] Units { get; set; }

        [JsonProperty("spells")]
        public HeroHealth[] Spells { get; set; }

        [JsonProperty("unit_upgrades")]
        public HeroHealth[] UnitUpgrades { get; set; }

        [JsonProperty("spell_upgrades")]
        public HeroHealth[] SpellUpgrades { get; set; }

        [JsonProperty("resources")]
        public HeroHealth[] Resources { get; set; }

        [JsonProperty("alliance_units")]
        public Dictionary<string, long>[] AllianceUnits { get; set; }

        [JsonProperty("hero_states")]
        public HeroHealth[] HeroStates { get; set; }

        [JsonProperty("hero_health")]
        public HeroHealth[] HeroHealth { get; set; }

        [JsonProperty("hero_upgrade")]
        public HeroHealth[] HeroUpgrade { get; set; }

        [JsonProperty("hero_modes")]
        public HeroHealth[] HeroModes { get; set; }

        [JsonProperty("variables")]
        public HeroHealth[] Variables { get; set; }

        [JsonProperty("units2")]
        public HeroHealth[] Units2 { get; set; }

        [JsonProperty("castle_lvl")]
        public long CastleLvl { get; set; }

        [JsonProperty("castle_total")]
        public long CastleTotal { get; set; }

        [JsonProperty("castle_used")]
        public long CastleUsed { get; set; }

        [JsonProperty("castle_total_sp")]
        public long CastleTotalSp { get; set; }

        [JsonProperty("castle_used_sp")]
        public long CastleUsedSp { get; set; }

        [JsonProperty("town_hall_lvl")]
        public long TownHallLvl { get; set; }

        [JsonProperty("th_v2_lvl")]
        public long ThV2Lvl { get; set; }

        [JsonProperty("lab_lvl")]
        public long LabLvl { get; set; }

        [JsonProperty("lab_v2_lvl")]
        public long LabV2Lvl { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("duel_score")]
        public long DuelScore { get; set; }
    }

    public partial class HeroHealth
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("cnt")]
        public long Cnt { get; set; }
    }

    public partial class Calendar
    {
        [JsonProperty("events")]
        public Event[] Events { get; set; }
    }

    public partial class Event
    {
        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("version")]
        public long Version { get; set; }

        [JsonProperty("visibleTime")]
        public string VisibleTime { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("clashBoxEntryName")]
        public string ClashBoxEntryName { get; set; }

        [JsonProperty("eventEntryName")]
        public string EventEntryName { get; set; }

        [JsonProperty("inboxEntryId")]
        public long InboxEntryId { get; set; }

        [JsonProperty("notificationTid")]
        public string NotificationTid { get; set; }

        [JsonProperty("scFile")]
        public File ScFile { get; set; }

        [JsonProperty("localizationFile")]
        public File LocalizationFile { get; set; }

        [JsonProperty("functions")]
        public object[] Functions { get; set; }

        [JsonProperty("lootLimitCooldownInMinutes", NullValueHandling = NullValueHandling.Ignore)]
        public long? LootLimitCooldownInMinutes { get; set; }

        [JsonProperty("duelBonusPercentWin", NullValueHandling = NullValueHandling.Ignore)]
        public long? DuelBonusPercentWin { get; set; }

        [JsonProperty("duelBonusPercentLose", NullValueHandling = NullValueHandling.Ignore)]
        public long? DuelBonusPercentLose { get; set; }

        [JsonProperty("duelBonusPercentDraw", NullValueHandling = NullValueHandling.Ignore)]
        public long? DuelBonusPercentDraw { get; set; }

        [JsonProperty("duelBonusMaxDiamondCostPercent", NullValueHandling = NullValueHandling.Ignore)]
        public long? DuelBonusMaxDiamondCostPercent { get; set; }

        [JsonProperty("imageFile", NullValueHandling = NullValueHandling.Ignore)]
        public File ImageFile { get; set; }

        [JsonProperty("pointsPerPlayer", NullValueHandling = NullValueHandling.Ignore)]
        public long? PointsPerPlayer { get; set; }

        [JsonProperty("minVisibleTasks", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinVisibleTasks { get; set; }

        [JsonProperty("maxVisibleTasks", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxVisibleTasks { get; set; }

        [JsonProperty("maxVisibleTasksWithSameType", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxVisibleTasksWithSameType { get; set; }

        [JsonProperty("initialTaskTrashCooldownInMinutes", NullValueHandling = NullValueHandling.Ignore)]
        public long? InitialTaskTrashCooldownInMinutes { get; set; }

        [JsonProperty("taskTrashCooldownIncrementInMinutes", NullValueHandling = NullValueHandling.Ignore)]
        public long? TaskTrashCooldownIncrementInMinutes { get; set; }

        [JsonProperty("maxTaskTrashCooldownInMinutes", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxTaskTrashCooldownInMinutes { get; set; }

        [JsonProperty("taskCooldownSkipCostPercent", NullValueHandling = NullValueHandling.Ignore)]
        public long? TaskCooldownSkipCostPercent { get; set; }

        [JsonProperty("minTownHallLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinTownHallLevel { get; set; }

        [JsonProperty("endingSoonNotificationMinutesFromEnd", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndingSoonNotificationMinutesFromEnd { get; set; }

        [JsonProperty("thresholds", NullValueHandling = NullValueHandling.Ignore)]
        public Threshold[] Thresholds { get; set; }

        [JsonProperty("overriddenTaskProbabilities", NullValueHandling = NullValueHandling.Ignore)]
        public object[] OverriddenTaskProbabilities { get; set; }

        [JsonProperty("overriddenTaskScores", NullValueHandling = NullValueHandling.Ignore)]
        public object[] OverriddenTaskScores { get; set; }

        [JsonProperty("boostedTasks", NullValueHandling = NullValueHandling.Ignore)]
        public string[] BoostedTasks { get; set; }

        [JsonProperty("boostedTaskExtraScorePercentage", NullValueHandling = NullValueHandling.Ignore)]
        public long? BoostedTaskExtraScorePercentage { get; set; }

        [JsonProperty("bannerTitleTid", NullValueHandling = NullValueHandling.Ignore)]
        public string BannerTitleTid { get; set; }
    }

    public partial class File
    {
        [JsonProperty("Path")]
        public string Path { get; set; }

        [JsonProperty("ChecksumSha1")]
        public string ChecksumSha1 { get; set; }
    }

    public partial class Threshold
    {
        [JsonProperty("points")]
        public long Points { get; set; }

        [JsonProperty("clanXP")]
        public long ClanXp { get; set; }

        [JsonProperty("rewards")]
        public Reward[] Rewards { get; set; }
    }

    public partial class Reward
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("spawnWeighting")]
        public long SpawnWeighting { get; set; }

        [JsonProperty("guaranteed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Guaranteed { get; set; }
    }

    public partial class Cmd
    {
        [JsonProperty("ct")]
        public long Ct { get; set; }

        [JsonProperty("c")]
        public C C { get; set; }
    }

    public partial class C
    {
        [JsonProperty("base")]
        public Base Base { get; set; }

        [JsonProperty("n", NullValueHandling = NullValueHandling.Ignore)]
        public long? N { get; set; }

        [JsonProperty("o", NullValueHandling = NullValueHandling.Ignore)]
        public long? O { get; set; }

        [JsonProperty("d", NullValueHandling = NullValueHandling.Ignore)]
        public long? D { get; set; }

        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public long? X { get; set; }

        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public long? Y { get; set; }
    }

    public partial class Base
    {
        [JsonProperty("t")]
        public long T { get; set; }
    }

    public partial class Globals
    {
        [JsonProperty("Globals")]
        public GlobalsClass GlobalsGlobals { get; set; }

        [JsonProperty("Village1")]
        public Village1 Village1 { get; set; }

        [JsonProperty("Village2")]
        public Village2 Village2 { get; set; }

        [JsonProperty("KillSwitches")]
        public KillSwitches KillSwitches { get; set; }
    }

    public partial class GlobalsClass
    {
        [JsonProperty("GiftPackExtension")]
        public string GiftPackExtension { get; set; }

        [JsonProperty("DuelLootLimitCooldownInMinutes")]
        public long DuelLootLimitCooldownInMinutes { get; set; }

        [JsonProperty("DuelBonusLimitWinsPerDay")]
        public long DuelBonusLimitWinsPerDay { get; set; }

        [JsonProperty("DuelBonusPercentWin")]
        public long DuelBonusPercentWin { get; set; }

        [JsonProperty("DuelBonusPercentLose")]
        public long DuelBonusPercentLose { get; set; }

        [JsonProperty("DuelBonusPercentDraw")]
        public long DuelBonusPercentDraw { get; set; }

        [JsonProperty("DuelBonusMaxDiamondCostPercent")]
        public long DuelBonusMaxDiamondCostPercent { get; set; }

        [JsonProperty("AllianceGamesPreparationTimeInMinutes")]
        public long AllianceGamesPreparationTimeInMinutes { get; set; }

        [JsonProperty("AllianceGamesMinTaskDifficulty")]
        public long AllianceGamesMinTaskDifficulty { get; set; }

        [JsonProperty("AllianceGamesMaxTaskDifficulty")]
        public long AllianceGamesMaxTaskDifficulty { get; set; }

        [JsonProperty("AllianceGamesPointsPerPlayer")]
        public long AllianceGamesPointsPerPlayer { get; set; }

        [JsonProperty("AllianceGamesInitialTaskTrashCooldownInMinutes")]
        public long AllianceGamesInitialTaskTrashCooldownInMinutes { get; set; }

        [JsonProperty("AllianceGamesTaskTrashCooldownIncrementInMinutes")]
        public long AllianceGamesTaskTrashCooldownIncrementInMinutes { get; set; }
    }

    public partial class KillSwitches
    {
        [JsonProperty("BattleWaitForProjectileDestruction")]
        public bool BattleWaitForProjectileDestruction { get; set; }

        [JsonProperty("BattleWaitForDieDamage")]
        public bool BattleWaitForDieDamage { get; set; }
    }

    public partial class Village1
    {
        [JsonProperty("SpecialObstacle")]
        public string SpecialObstacle { get; set; }
    }

    public partial class Village2
    {
        [JsonProperty("TownHallMaxLevel")]
        public long TownHallMaxLevel { get; set; }

        [JsonProperty("ScoreChangeForLosing")]
        public ScoreChangeForLosing[] ScoreChangeForLosing { get; set; }

        [JsonProperty("StrengthRangeForScore")]
        public ScoreChangeForLosing[] StrengthRangeForScore { get; set; }
    }

    public partial class ScoreChangeForLosing
    {
        [JsonProperty("Percentage")]
        public long Percentage { get; set; }

        [JsonProperty("Milestone")]
        public long Milestone { get; set; }
    }

    public partial class Level
    {
        [JsonProperty("wave_num")]
        public long WaveNum { get; set; }

        [JsonProperty("exp_ver")]
        public long ExpVer { get; set; }

        [JsonProperty("android_client")]
        public bool AndroidClient { get; set; }

        [JsonProperty("direct2")]
        public bool Direct2 { get; set; }

        [JsonProperty("active_layout")]
        public long ActiveLayout { get; set; }

        [JsonProperty("act_l2")]
        public long ActL2 { get; set; }

        [JsonProperty("layout_state")]
        public long[] LayoutState { get; set; }

        [JsonProperty("layout_state2")]
        public long[] LayoutState2 { get; set; }

        [JsonProperty("layout_cooldown")]
        public long[] LayoutCooldown { get; set; }

        [JsonProperty("buildings")]
        public object[] Buildings { get; set; }

        [JsonProperty("obstacles")]
        public object[] Obstacles { get; set; }

        [JsonProperty("traps")]
        public object[] Traps { get; set; }

        [JsonProperty("decos")]
        public object[] Decos { get; set; }

        [JsonProperty("vobjs")]
        public object[] Vobjs { get; set; }

        [JsonProperty("respawnVars")]
        public RespawnVars RespawnVars { get; set; }

        [JsonProperty("units")]
        public Spells Units { get; set; }

        [JsonProperty("spells")]
        public Spells Spells { get; set; }

        [JsonProperty("buildings2")]
        public Buildings2[] Buildings2 { get; set; }

        [JsonProperty("obstacles2")]
        public Obstacles2[] Obstacles2 { get; set; }

        [JsonProperty("traps2")]
        public Traps2[] Traps2 { get; set; }

        [JsonProperty("decos2")]
        public object[] Decos2 { get; set; }

        [JsonProperty("vobjs2")]
        public Obstacles2[] Vobjs2 { get; set; }

        [JsonProperty("v2rs")]
        public long V2Rs { get; set; }

        [JsonProperty("v2rseed")]
        public long V2Rseed { get; set; }

        [JsonProperty("v2ccounter")]
        public long V2Ccounter { get; set; }

        [JsonProperty("tgsec")]
        public long Tgsec { get; set; }

        [JsonProperty("tgseed")]
        public long Tgseed { get; set; }

        [JsonProperty("cooldowns")]
        public object[] Cooldowns { get; set; }

        [JsonProperty("newShopBuildings")]
        public long[] NewShopBuildings { get; set; }

        [JsonProperty("newShopTraps")]
        public long[] NewShopTraps { get; set; }

        [JsonProperty("newShopDecos")]
        public long[] NewShopDecos { get; set; }

        [JsonProperty("offer")]
        public Offer Offer { get; set; }

        [JsonProperty("last_league_rank")]
        public long LastLeagueRank { get; set; }

        [JsonProperty("last_alliance_level")]
        public long LastAllianceLevel { get; set; }

        [JsonProperty("last_league_shuffle")]
        public long LastLeagueShuffle { get; set; }

        [JsonProperty("last_season_seen")]
        public long LastSeasonSeen { get; set; }

        [JsonProperty("last_news_seen")]
        public long LastNewsSeen { get; set; }

        [JsonProperty("war_tutorials_seen")]
        public long WarTutorialsSeen { get; set; }

        [JsonProperty("war_base")]
        public bool WarBase { get; set; }

        [JsonProperty("arr_war_base")]
        public bool ArrWarBase { get; set; }

        [JsonProperty("army_names")]
        public string[] ArmyNames { get; set; }

        [JsonProperty("account_flags")]
        public long AccountFlags { get; set; }

        [JsonProperty("bool_layout_edit_shown_erase")]
        public bool BoolLayoutEditShownErase { get; set; }

        [JsonProperty("events")]
        public long[] Events { get; set; }

        [JsonProperty("es")]
        public long Es { get; set; }

        [JsonProperty("alliance_games")]
        public AllianceGames AllianceGames { get; set; }

        [JsonProperty("trader")]
        public Trader Trader { get; set; }

        [JsonProperty("disableShopPersonalisation")]
        public bool DisableShopPersonalisation { get; set; }
    }

    public partial class AllianceGames
    {
        [JsonProperty("last_seen")]
        public long LastSeen { get; set; }

        [JsonProperty("last_id")]
        public long LastId { get; set; }

        [JsonProperty("last_end")]
        public long LastEnd { get; set; }

        [JsonProperty("p_score")]
        public long PScore { get; set; }

        [JsonProperty("p_max")]
        public long PMax { get; set; }

        [JsonProperty("a_score")]
        public long AScore { get; set; }

        [JsonProperty("cooldown")]
        public long Cooldown { get; set; }

        [JsonProperty("n_cooldown")]
        public long NCooldown { get; set; }

        [JsonProperty("last_seen_id")]
        public long LastSeenId { get; set; }

        [JsonProperty("thresholds")]
        public object[] Thresholds { get; set; }

        [JsonProperty("rewards")]
        public object[] Rewards { get; set; }

        [JsonProperty("thresholdXP")]
        public object[] ThresholdXp { get; set; }

        [JsonProperty("reward_indices")]
        public object[] RewardIndices { get; set; }

        [JsonProperty("chosen_indices")]
        public object[] ChosenIndices { get; set; }

        [JsonProperty("rewards_claimed")]
        public bool RewardsClaimed { get; set; }
    }

    public partial class Buildings2
    {
        [JsonProperty("data")]
        public long Data { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("lvl")]
        public long Lvl { get; set; }

        [JsonProperty("x")]
        public long X { get; set; }

        [JsonProperty("y")]
        public long Y { get; set; }

        [JsonProperty("wI", NullValueHandling = NullValueHandling.Ignore)]
        public long? WI { get; set; }

        [JsonProperty("wX", NullValueHandling = NullValueHandling.Ignore)]
        public long? WX { get; set; }

        [JsonProperty("res_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ResTime { get; set; }

        [JsonProperty("unit_prod", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleUnitProd UnitProd { get; set; }

        [JsonProperty("up2", NullValueHandling = NullValueHandling.Ignore)]
        public Up2Class Up2 { get; set; }

        [JsonProperty("attack_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AttackMode { get; set; }

        [JsonProperty("attack_mode_draft", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AttackModeDraft { get; set; }

        [JsonProperty("attack_mode_war", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AttackModeWar { get; set; }

        [JsonProperty("attack_mode_draft_war", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AttackModeDraftWar { get; set; }

        [JsonProperty("attack_mode2", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AttackMode2 { get; set; }

        [JsonProperty("attack_mode_d2", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AttackModeD2 { get; set; }

        [JsonProperty("attack_mode3", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AttackMode3 { get; set; }

        [JsonProperty("attack_mode_d3", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AttackModeD3 { get; set; }

        [JsonProperty("attack_mode4", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AttackMode4 { get; set; }

        [JsonProperty("attack_mode_d4", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AttackModeD4 { get; set; }

        [JsonProperty("attack_mode5", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AttackMode5 { get; set; }

        [JsonProperty("attack_mode_d5", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AttackModeD5 { get; set; }

        [JsonProperty("attack_mode_chal", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AttackModeChal { get; set; }

        [JsonProperty("attack_mode_dchal", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AttackModeDchal { get; set; }

        [JsonProperty("attack_mode_arrw", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AttackModeArrw { get; set; }

        [JsonProperty("attack_mode_draft_arrw", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AttackModeDraftArrw { get; set; }

        [JsonProperty("const_t", NullValueHandling = NullValueHandling.Ignore)]
        public long? ConstT { get; set; }
    }

    public partial class PurpleUnitProd
    {
        [JsonProperty("m")]
        public long M { get; set; }

        [JsonProperty("unit_type")]
        public long UnitType { get; set; }
    }

    public partial class Up2Class
    {
    }

    public partial class Obstacles2
    {
        [JsonProperty("data")]
        public long Data { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("x")]
        public long X { get; set; }

        [JsonProperty("y")]
        public long Y { get; set; }

        [JsonProperty("lvl", NullValueHandling = NullValueHandling.Ignore)]
        public long? Lvl { get; set; }
    }

    public partial class Offer
    {
        [JsonProperty("offers")]
        public object[] Offers { get; set; }
    }

    public partial class RespawnVars
    {
        [JsonProperty("secondsFromLastRespawn")]
        public long SecondsFromLastRespawn { get; set; }

        [JsonProperty("respawnSeed")]
        public long RespawnSeed { get; set; }

        [JsonProperty("obstacleClearCounter")]
        public long ObstacleClearCounter { get; set; }

        [JsonProperty("time_to_gembox_drop")]
        public long TimeToGemboxDrop { get; set; }

        [JsonProperty("time_in_gembox_period")]
        public long TimeInGemboxPeriod { get; set; }
    }

    public partial class Spells
    {
        [JsonProperty("unit_prod")]
        public Up2Class UnitProd { get; set; }
    }

    public partial class Trader
    {
        [JsonProperty("day")]
        public long Day { get; set; }

        [JsonProperty("cycle")]
        public long Cycle { get; set; }

        [JsonProperty("seen")]
        public bool Seen { get; set; }
    }

    public partial class Traps2
    {
        [JsonProperty("data")]
        public long Data { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("lvl")]
        public long Lvl { get; set; }

        [JsonProperty("trapd", NullValueHandling = NullValueHandling.Ignore)]
        public long? Trapd { get; set; }

        [JsonProperty("trapd_draft", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrapdDraft { get; set; }

        [JsonProperty("trapd_war", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrapdWar { get; set; }

        [JsonProperty("trapd_draft_war", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrapdDraftWar { get; set; }

        [JsonProperty("trapd2", NullValueHandling = NullValueHandling.Ignore)]
        public long? Trapd2 { get; set; }

        [JsonProperty("trapd_d2", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrapdD2 { get; set; }

        [JsonProperty("trapd3", NullValueHandling = NullValueHandling.Ignore)]
        public long? Trapd3 { get; set; }

        [JsonProperty("trapd_d3", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrapdD3 { get; set; }

        [JsonProperty("trapd4", NullValueHandling = NullValueHandling.Ignore)]
        public long? Trapd4 { get; set; }

        [JsonProperty("trapd_d4", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrapdD4 { get; set; }

        [JsonProperty("trapd5", NullValueHandling = NullValueHandling.Ignore)]
        public long? Trapd5 { get; set; }

        [JsonProperty("trapd_d5", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrapdD5 { get; set; }

        [JsonProperty("trapd6", NullValueHandling = NullValueHandling.Ignore)]
        public long? Trapd6 { get; set; }

        [JsonProperty("trapd_d6", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrapdD6 { get; set; }

        [JsonProperty("trapd7", NullValueHandling = NullValueHandling.Ignore)]
        public long? Trapd7 { get; set; }

        [JsonProperty("trapd_d7", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrapdD7 { get; set; }

        [JsonProperty("x")]
        public long X { get; set; }

        [JsonProperty("y")]
        public long Y { get; set; }

        [JsonProperty("air_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AirMode { get; set; }

        [JsonProperty("air_mode_draft", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AirModeDraft { get; set; }

        [JsonProperty("air_mode_war", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AirModeWar { get; set; }

        [JsonProperty("air_mode_draft_war", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AirModeDraftWar { get; set; }

        [JsonProperty("air_mode2", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AirMode2 { get; set; }

        [JsonProperty("air_mode_d2", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AirModeD2 { get; set; }

        [JsonProperty("air_mode3", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AirMode3 { get; set; }

        [JsonProperty("air_mode_d3", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AirModeD3 { get; set; }

        [JsonProperty("air_mode4", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AirMode4 { get; set; }

        [JsonProperty("air_mode_d4", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AirModeD4 { get; set; }

        [JsonProperty("air_mode5", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AirMode5 { get; set; }

        [JsonProperty("air_mode_d5", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AirModeD5 { get; set; }

        [JsonProperty("air_mode6", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AirMode6 { get; set; }

        [JsonProperty("air_mode_d6", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AirModeD6 { get; set; }

        [JsonProperty("air_mode7", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AirMode7 { get; set; }

        [JsonProperty("air_mode_d7", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AirModeD7 { get; set; }
    }

        public partial class MagicReplays
    {
        public static MagicReplays FromJson(string json) => JsonConvert.DeserializeObject<MagicReplays>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this MagicReplays self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    
}
}
