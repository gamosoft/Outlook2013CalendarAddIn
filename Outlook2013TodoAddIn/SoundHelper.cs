using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Outlook2013TodoAddIn
{
    /// <summary>
    /// Native calls to play sounds
    /// </summary>
    public class SoundHelper
    {
        #region "Variables"

        /// <summary>
        /// SND_NODEFAULT -> 0x0002
        /// </summary>
        public const uint SND_NODEFAULT = 0x0002;

        /// <summary>
        /// Mail notification sound
        /// </summary>
        public const string MailBeep = "MailBeep";

        #endregion "Variables"

        #region "Methods"

        /// <summary>
        /// Call to play a system sound
        /// </summary>
        /// <param name="pszSound">Eg.: MailBeep</param>
        /// <param name="fuSound"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImportAttribute("winmm.dll", EntryPoint = "sndPlaySoundW")]
        [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
        public static extern bool sndPlaySoundW([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string pszSound, uint fuSound);

        #endregion "Methods"

        /// Return Type: BOOL->int
        ///pszSound: LPCWSTR->WCHAR*
        ///fuSound: UINT->unsigned int


    }
}