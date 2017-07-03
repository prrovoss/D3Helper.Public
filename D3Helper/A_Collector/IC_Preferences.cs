using System;

using Enigma.D3.Enums;
using Enigma.D3.MemoryModel.Preferences;
using Enigma.D3.MemoryModel;

namespace D3Helper.A_Collector
{
    class IC_Preferences
    {
        private static DateTime _nextCollect = DateTime.Now;
        private const int _intervallCollects = 1000; // Collect every x msec

        public static void Collect()
        {
            try
            {
                if (DateTime.Now >= _nextCollect)
                {

                    get_ForceMove();
                    get_ForceStandStill();
                    get_ToggleInventory();
                    get_ToggleParagon();
                    get_ActionBarSkills();
                    get_Potion();
                    get_Townportal();
                    get_SkillsWindow();
                    get_CloseAllWindows();

                    _nextCollect = DateTime.Now.AddMilliseconds(_intervallCollects);

                }
            }
            catch (Exception e)
            {
                A_Handler.Log.Exception.addExceptionLogEntry(e, A_Enums.ExceptionThread.ICollector);
            }
        }


        public static Hotkey GetHotKeyByIndex(HotkeyIndex index)
        {
            if ((int)index >= 70)
                throw new ArgumentOutOfRangeException("index");

            return MemoryContext.Current.DataSegment.HotkeyPreferences.Hotkeys[(int)index];
        }


        private static void get_ForceMove()
        {
            try
            {
                A_Collection.Preferences.Hotkeys.Key1_ForceMove = GetHotKeyByIndex(HotkeyIndex.ForceMove).PrimaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey1_ForceMove = GetHotKeyByIndex(HotkeyIndex.ForceMove).PrimaryGesture.Modifiers;
                A_Collection.Preferences.Hotkeys.Key2_ForceMove = GetHotKeyByIndex(HotkeyIndex.ForceMove).SecondaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey2_ForceMove = GetHotKeyByIndex(HotkeyIndex.ForceMove).SecondaryGesture.Modifiers;

            }
            catch (Exception e)
            {
                A_Handler.Log.Exception.addExceptionLogEntry(e, A_Enums.ExceptionThread.ICollector);
            }
        }


        private static void get_Potion()
        {
            try
            {
                A_Collection.Preferences.Hotkeys.Key1_Potion = GetHotKeyByIndex(HotkeyIndex.PotionButton).PrimaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey1_Potion = GetHotKeyByIndex(HotkeyIndex.PotionButton).PrimaryGesture.Modifiers;
                A_Collection.Preferences.Hotkeys.Key2_Potion = GetHotKeyByIndex(HotkeyIndex.PotionButton).SecondaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey2_Potion = GetHotKeyByIndex(HotkeyIndex.PotionButton).SecondaryGesture.Modifiers;

            }
            catch (Exception e)
            {
                A_Handler.Log.Exception.addExceptionLogEntry(e, A_Enums.ExceptionThread.ICollector);
            }
        }


        private static void get_Townportal()
        {
            try
            {
                A_Collection.Preferences.Hotkeys.Key1_Townportal = GetHotKeyByIndex(HotkeyIndex.TownPortal).PrimaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey1_Townportal = GetHotKeyByIndex(HotkeyIndex.TownPortal).PrimaryGesture.Modifiers; ;
                A_Collection.Preferences.Hotkeys.Key2_Townportal = GetHotKeyByIndex(HotkeyIndex.TownPortal).SecondaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey2_Townportal = GetHotKeyByIndex(HotkeyIndex.TownPortal).SecondaryGesture.Modifiers; ;

            }
            catch (Exception e)
            {
                A_Handler.Log.Exception.addExceptionLogEntry(e, A_Enums.ExceptionThread.ICollector);
            }
        }


        private static void get_SkillsWindow()
        {
            try
            {
                A_Collection.Preferences.Hotkeys.Key1_SkillsWindow = GetHotKeyByIndex(HotkeyIndex.ToggleSkillMenu).PrimaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey1_SkillsWindow = GetHotKeyByIndex(HotkeyIndex.ToggleSkillMenu).PrimaryGesture.Modifiers;
                A_Collection.Preferences.Hotkeys.Key2_SkillsWindow = GetHotKeyByIndex(HotkeyIndex.ToggleSkillMenu).SecondaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey2_SkillsWindow = GetHotKeyByIndex(HotkeyIndex.ToggleSkillMenu).SecondaryGesture.Modifiers;

            }
            catch (Exception e)
            {
                A_Handler.Log.Exception.addExceptionLogEntry(e, A_Enums.ExceptionThread.ICollector);
            }
        }


        private static void get_CloseAllWindows()
        {
            try
            {
                A_Collection.Preferences.Hotkeys.Key1_CloseAllWindows = GetHotKeyByIndex(HotkeyIndex.CloseAllOpenWindows).PrimaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey1_CloseAllWindows = GetHotKeyByIndex(HotkeyIndex.CloseAllOpenWindows).PrimaryGesture.Modifiers;
                A_Collection.Preferences.Hotkeys.Key2_CloseAllWindows = GetHotKeyByIndex(HotkeyIndex.CloseAllOpenWindows).SecondaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey2_CloseAllWindows = GetHotKeyByIndex(HotkeyIndex.CloseAllOpenWindows).SecondaryGesture.Modifiers;

            }
            catch (Exception e)
            {
                A_Handler.Log.Exception.addExceptionLogEntry(e, A_Enums.ExceptionThread.ICollector);
            }
        }


        private static void get_ForceStandStill()
        {
            try
            {
                A_Collection.Preferences.Hotkeys.Key1_ForceStandStill = GetHotKeyByIndex(HotkeyIndex.ForceStandStill).PrimaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey1_ForceStandStill = GetHotKeyByIndex(HotkeyIndex.ForceStandStill).PrimaryGesture.Modifiers;
                A_Collection.Preferences.Hotkeys.Key2_ForceStandStill = GetHotKeyByIndex(HotkeyIndex.ForceStandStill).SecondaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey2_ForceStandStill = GetHotKeyByIndex(HotkeyIndex.ForceStandStill).SecondaryGesture.Modifiers;

            }
            catch (Exception e)
            {
                A_Handler.Log.Exception.addExceptionLogEntry(e, A_Enums.ExceptionThread.ICollector);
            }
        }


        private static void get_ToggleInventory()
        {
            try
            {
                A_Collection.Preferences.Hotkeys.Key1_OpenInventory = GetHotKeyByIndex(HotkeyIndex.ToggleInventoryMenu).PrimaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey1_OpenInventory = GetHotKeyByIndex(HotkeyIndex.ToggleInventoryMenu).PrimaryGesture.Modifiers;
                A_Collection.Preferences.Hotkeys.Key2_OpenInventory = GetHotKeyByIndex(HotkeyIndex.ToggleInventoryMenu).SecondaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey2_OpenInventory = GetHotKeyByIndex(HotkeyIndex.ToggleInventoryMenu).SecondaryGesture.Modifiers;

            }
            catch (Exception e)
            {
                A_Handler.Log.Exception.addExceptionLogEntry(e, A_Enums.ExceptionThread.ICollector);
            }
        }


        private static void get_ToggleParagon()
        {
            try
            {
                A_Collection.Preferences.Hotkeys.Key1_OpenParagon = GetHotKeyByIndex(HotkeyIndex.Paragon).PrimaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey1_OpenParagon = GetHotKeyByIndex(HotkeyIndex.Paragon).PrimaryGesture.Modifiers;
                A_Collection.Preferences.Hotkeys.Key2_OpenParagon = GetHotKeyByIndex(HotkeyIndex.Paragon).SecondaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey2_OpenParagon = GetHotKeyByIndex(HotkeyIndex.Paragon).SecondaryGesture.Modifiers;
            }
            catch (Exception e)
            {
                A_Handler.Log.Exception.addExceptionLogEntry(e, A_Enums.ExceptionThread.ICollector);
            }
        }


        private static void get_ActionBarSkills()
        {
            try
            {
                A_Collection.Preferences.Hotkeys.Key1_ActionBarSkill1 = GetHotKeyByIndex(HotkeyIndex.ActionBarSkill1).PrimaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey1_ActionBarSkill1 = GetHotKeyByIndex(HotkeyIndex.ActionBarSkill1).PrimaryGesture.Modifiers;

                A_Collection.Preferences.Hotkeys.Key1_ActionBarSkill2 = GetHotKeyByIndex(HotkeyIndex.ActionBarSkill2).PrimaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey1_ActionBarSkill2 = GetHotKeyByIndex(HotkeyIndex.ActionBarSkill2).PrimaryGesture.Modifiers;

                A_Collection.Preferences.Hotkeys.Key1_ActionBarSkill3 = GetHotKeyByIndex(HotkeyIndex.ActionBarSkill3).PrimaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey1_ActionBarSkill3 = GetHotKeyByIndex(HotkeyIndex.ActionBarSkill3).PrimaryGesture.Modifiers;

                A_Collection.Preferences.Hotkeys.Key1_ActionBarSkill4 = GetHotKeyByIndex(HotkeyIndex.ActionBarSkill4).PrimaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey1_ActionBarSkill4 = GetHotKeyByIndex(HotkeyIndex.ActionBarSkill4).PrimaryGesture.Modifiers;

                A_Collection.Preferences.Hotkeys.Key2_ActionBarSkill1 = GetHotKeyByIndex(HotkeyIndex.ActionBarSkill1).SecondaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey2_ActionBarSkill1 = GetHotKeyByIndex(HotkeyIndex.ActionBarSkill1).SecondaryGesture.Modifiers;

                A_Collection.Preferences.Hotkeys.Key2_ActionBarSkill2 = GetHotKeyByIndex(HotkeyIndex.ActionBarSkill2).SecondaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey2_ActionBarSkill2 = GetHotKeyByIndex(HotkeyIndex.ActionBarSkill2).SecondaryGesture.Modifiers;

                A_Collection.Preferences.Hotkeys.Key2_ActionBarSkill3 = GetHotKeyByIndex(HotkeyIndex.ActionBarSkill3).SecondaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey2_ActionBarSkill3 = GetHotKeyByIndex(HotkeyIndex.ActionBarSkill3).SecondaryGesture.Modifiers;

                A_Collection.Preferences.Hotkeys.Key2_ActionBarSkill4 = GetHotKeyByIndex(HotkeyIndex.ActionBarSkill4).SecondaryGesture.Key;
                A_Collection.Preferences.Hotkeys.ModKey2_ActionBarSkill4 = GetHotKeyByIndex(HotkeyIndex.ActionBarSkill4).SecondaryGesture.Modifiers;

            }
            catch (Exception e)
            {
                A_Handler.Log.Exception.addExceptionLogEntry(e, A_Enums.ExceptionThread.ICollector);
            }
        }
    }
}
