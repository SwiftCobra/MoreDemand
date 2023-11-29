using System.Reflection;
using BepInEx.Logging;
using HarmonyLib;
using Game.Simulation;
using Colossal.Collections;
using Colossal.IO.AssetDatabase;
using Unity.Mathematics;
using Game.Prefabs;
using Unity.Collections;
using Unity.Jobs;
using Unity.Entities;
using Unity.Serialization.Json;

namespace MoreDemand.Patches 
{

    [HarmonyPatch(typeof(ResidentialDemandSystem), "OnUpdate")]
    class ResidentialDemandSystem_OnUpdate
    {
        static void Postfix(ResidentialDemandSystem __instance)
        {
            JobHandle outJobHandle3;
            //var Logger = BepInEx.Logging.Logger.CreateLogSource(MyPluginInfo.PLUGIN_NAME);

            //Logger.LogInfo("Running ResidentialDemandSystem Demand On Update");

            var type = typeof(ResidentialDemandSystem);
            
            var m_buildingDemand = (NativeValue<int3>)type.GetField("m_BuildingDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
            //Logger.LogInfo($"Got DemandVariable m_buildingDemand {m_buildingDemand.value}");

            //var m_HouseholdDemand = (NativeValue<int>)type.GetField("m_HouseholdDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
            //Logger.LogInfo($"Got DemandVariable m_HouseholdDemand {m_HouseholdDemand.value}");

            //var m_LastBuildingDemand = (int3)type.GetField("m_LastBuildingDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
            //Logger.LogInfo($"Got DemandVariable m_LastBuildingDemand {m_LastBuildingDemand}");

            //var m_LastHouseholdDemand = (int)type.GetField("m_LastHouseholdDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
            //Logger.LogInfo($"Got DemandVariable m_LastHouseholdDemand {m_LastHouseholdDemand}");

            m_buildingDemand.value = new int3(1667, 1667, 1667); //5001 total
        }
    }

    [HarmonyPatch(typeof(CommercialDemandSystem), "OnUpdate")]
    class CommercialDemandSystem_OnUpdate
    {
        static void Prefix(CommercialDemandSystem __instance)
        {
            var type = typeof(CommercialDemandSystem);
            var m_buildingDemand = (NativeValue<int>)type.GetField("m_BuildingDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
            //var m_CompanyDemand = (NativeValue<int>)type.GetField("m_CompanyDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
            //var m_LastCompanyDemand = (int)type.GetField("m_LastCompanyDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
            //var m_LastBuildingDemand = (int)type.GetField("m_LastBuildingDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);

            m_buildingDemand.value = 5001;
        }
    }

    [HarmonyPatch(typeof(IndustrialDemandSystem), "OnUpdate")]
    class IndustrialDemandSystem_OnUpdate
    {
        static void Prefix(IndustrialDemandSystem __instance)
        {
            // Specify which log messages you want to listen to
            //var Logger = BepInEx.Logging.Logger.CreateLogSource(MyPluginInfo.PLUGIN_NAME);

            //Logger.LogInfo("Running IndustrialDemandSystem Demand On Update");
            var type = typeof(IndustrialDemandSystem);
            //Logger.LogInfo("Got System Type");

            var m_IndustrialCompanyDemand = (NativeValue<int>)type.GetField("m_IndustrialCompanyDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
            //Logger.LogInfo($"Got DemandVariable m_IndustrialCompanyDemand {m_IndustrialCompanyDemand.value}");

            var m_IndustrialBuildingDemand = (NativeValue<int>)type.GetField("m_IndustrialBuildingDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
            //Logger.LogInfo($"Got DemandVariable m_IndustrialBuildingDemand {m_IndustrialBuildingDemand.value}");
            var m_StorageCompanyDemand = (NativeValue<int>)type.GetField("m_StorageCompanyDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
            //Logger.LogInfo($"Got DemandVariable m_StorageCompanyDemand {m_StorageCompanyDemand.value}");
            var m_StorageBuildingDemand = (NativeValue<int>)type.GetField("m_StorageBuildingDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
            //Logger.LogInfo($"Got DemandVariable m_StorageBuildingDemand {m_StorageBuildingDemand.value}");
            var m_OfficeCompanyDemand = (NativeValue<int>)type.GetField("m_OfficeCompanyDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
            //Logger.LogInfo($"Got DemandVariable m_OfficeCompanyDemand {m_OfficeCompanyDemand.value}");
            var m_OfficeBuildingDemand = (NativeValue<int>)type.GetField("m_OfficeBuildingDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
            //Logger.LogInfo($"Got DemandVariable m_OfficeBuildingDemand {m_OfficeBuildingDemand.value}");


            //var m_LastIndustrialCompanyDemand = (int)type.GetField("m_LastIndustrialCompanyDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
            //Logger.LogInfo($"Got DemandVariable m_LastIndustrialCompanyDemand {m_LastIndustrialCompanyDemand}");
            //var m_LastIndustrialBuildingDemand = (int)type.GetField("m_LastIndustrialBuildingDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
            //Logger.LogInfo($"Got DemandVariable m_LastIndustrialBuildingDemand {m_LastIndustrialBuildingDemand}");
            //var m_LastStorageCompanyDemand = (int)type.GetField("m_LastStorageCompanyDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
            //Logger.LogInfo($"Got DemandVariable m_LastStorageCompanyDemand {m_LastStorageCompanyDemand}");
            //var m_LastStorageBuildingDemand = (int)type.GetField("m_LastStorageBuildingDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
            //Logger.LogInfo($"Got DemandVariable m_LastStorageBuildingDemand {m_LastStorageBuildingDemand}");
            //var m_LastOfficeCompanyDemand = (int)type.GetField("m_LastOfficeCompanyDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
            //Logger.LogInfo($"Got DemandVariable m_LastOfficeCompanyDemand {m_LastOfficeCompanyDemand}");
            //var m_LastOfficeBuildingDemand = (int)type.GetField("m_LastOfficeBuildingDemand", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(__instance);
            //Logger.LogInfo($"Got DemandVariable m_LastOfficeBuildingDemand {m_LastOfficeBuildingDemand}");

            m_IndustrialBuildingDemand.value = 5001;
            m_IndustrialCompanyDemand.value = 100;
            m_StorageBuildingDemand.value = 100;
            m_StorageCompanyDemand.value = 100;
            m_OfficeBuildingDemand.value = 5001;
            m_OfficeCompanyDemand.value = 100;
            //Logger.LogInfo($"Set DemandVariable {m_buildingDemand.value}");
        }
    }

    //Turn on instant build
    [HarmonyPatch(typeof(ZoneSpawnSystem), "OnCreate")]
    class ZoneSpawnSystem_OnCreate
    {
        static void Prefix(ZoneSpawnSystem __instance)
        {
            __instance.debugFastSpawn = true;
        }
    }
}