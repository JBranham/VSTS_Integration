﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace VSTS_Integration
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("88316537-bab9-44eb-8ae8-a6125d3fcfb2", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the VSTS_IntegrationRepository repository.
        /// </summary>
        public static VSTS_IntegrationRepository repo = VSTS_IntegrationRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://www.ranorex.com/web-testing-examples/vip/' with browser 'IE' in normal mode .", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://www.ranorex.com/web-testing-examples/vip/", "IE", "", false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RanorexVIPDatabaseTestWebApplicatio.FirstName' at 16;6.", repo.RanorexVIPDatabaseTestWebApplicatio.FirstNameInfo, new RecordItemIndex(1));
            repo.RanorexVIPDatabaseTestWebApplicatio.FirstName.Click("16;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Jay' with focus on 'RanorexVIPDatabaseTestWebApplicatio.FirstName'.", repo.RanorexVIPDatabaseTestWebApplicatio.FirstNameInfo, new RecordItemIndex(2));
            repo.RanorexVIPDatabaseTestWebApplicatio.FirstName.PressKeys("Jay");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RanorexVIPDatabaseTestWebApplicatio.LastName' at 20;5.", repo.RanorexVIPDatabaseTestWebApplicatio.LastNameInfo, new RecordItemIndex(3));
            repo.RanorexVIPDatabaseTestWebApplicatio.LastName.Click("20;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Branham' with focus on 'RanorexVIPDatabaseTestWebApplicatio.LastName'.", repo.RanorexVIPDatabaseTestWebApplicatio.LastNameInfo, new RecordItemIndex(4));
            repo.RanorexVIPDatabaseTestWebApplicatio.LastName.PressKeys("Branham");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RanorexVIPDatabaseTestWebApplicatio.Music' at 29;10.", repo.RanorexVIPDatabaseTestWebApplicatio.MusicInfo, new RecordItemIndex(5));
            repo.RanorexVIPDatabaseTestWebApplicatio.Music.Click("29;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RanorexVIPDatabaseTestWebApplicatio.Gender' at 12;9.", repo.RanorexVIPDatabaseTestWebApplicatio.GenderInfo, new RecordItemIndex(6));
            repo.RanorexVIPDatabaseTestWebApplicatio.Gender.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RanorexVIPDatabaseTestWebApplicatio.InputTagAdd' at 31;11.", repo.RanorexVIPDatabaseTestWebApplicatio.InputTagAddInfo, new RecordItemIndex(7));
            repo.RanorexVIPDatabaseTestWebApplicatio.InputTagAdd.Click("31;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='VIP count: 1') on item 'RanorexVIPDatabaseTestWebApplicatio.Count'.", repo.RanorexVIPDatabaseTestWebApplicatio.CountInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.RanorexVIPDatabaseTestWebApplicatio.CountInfo, "InnerText", "VIP count: 1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RanorexVIPDatabaseTestWebApplicatio.Clear' at 8;9.", repo.RanorexVIPDatabaseTestWebApplicatio.ClearInfo, new RecordItemIndex(9));
            repo.RanorexVIPDatabaseTestWebApplicatio.Clear.Click("8;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'RanorexVIPDatabaseTestWebApplicatio'.", repo.RanorexVIPDatabaseTestWebApplicatio.SelfInfo, new RecordItemIndex(10));
            Host.Current.CloseApplication(repo.RanorexVIPDatabaseTestWebApplicatio.Self, new Duration(0));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "MAKING A CHANGE", new RecordItemIndex(11));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
