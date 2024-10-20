﻿using ASCOM.DSLR.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using Logging;

namespace ASCOM.DSLR.Classes
{
    [Serializable]
    public class CameraSettings
    {
        public CameraSettings()
        {
            TraceLog = true;
            CameraMode = CameraMode.RGGB;
            StorePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "ASCOM_DSLR");
            SaveFile = true;
            IntegrationApi = ConnectionMethod.NikonLegacy;
            Iso = 100;
            BackyardEosPort = 1491;
            LiveViewZoom = LiveViewZoom.Fit;
            BinningMode = BinningMode.Sum;
            CameraModelsHistory = new List<CameraModel>();
            LogLevel = DebugLogLevels.Error;
            maxADU = 16384;
        }

        public bool TraceLog { get; set; }

        public CameraMode CameraMode { get; set; }

        public ConnectionMethod IntegrationApi { get; set; }

        public string StorePath { get; set; }

        public bool SaveFile { get; set; }

        public int maxADU { get; set; }

        public bool maxADUOverride { get; set; }

        
        public short Iso { get; set; }

        public int BackyardEosPort { get; set; }

        public bool LiveViewCaptureMode { get; set; }

        public LiveViewZoom LiveViewZoom { get; set; }

        public List<CameraModel> CameraModelsHistory { get; set; }

        public BinningMode BinningMode { get; set; }

        public bool EnableBinning { get; set; }

        public bool UseExternalShutter { get; set; }

        public string ExternalShutterPortName { get; set; }
        
        public DebugLogLevels LogLevel { get; set; }

    }
}
