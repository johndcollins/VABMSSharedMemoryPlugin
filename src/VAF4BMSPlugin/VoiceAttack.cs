using System;

namespace VAF4BMSPlugin
{
    public class VoiceAttack
    {
        private static F4SimConnector _connector;

        public static string VA_DisplayName()
        {
            return "Falcon BMS VoiceAttack Plugin - v1.0.0";
        }

        public static string VA_DisplayInfo()
        {
            return "Falcon BMS VoiceAttack Plugin\r\n\r\nVoice Attack Integration with Falcon BMS.\r\n\r\nCopyright 2023 JJBravo";
        }

        public static Guid VA_Id()
        {
            return new Guid("{BDA340CF-9E4A-4B71-B883-BD2C97650D02}");
        }

        public static void VA_Init1(dynamic vaProxy)
        {
            _connector = new F4SimConnector();
        }

        public static void VA_StopCommand()
        {
        }

        public static void VA_Exit1(dynamic vaProxy)
        {
            _connector.Dispose();
            _connector = null;
        }

        public static void VA_Invoke1(dynamic vaProxy)
        {
            _connector.Update();

            _connector.GetValue(vaProxy);
        }
    }
}
