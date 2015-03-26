using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Outlook2013TodoAddIn
{
    /// <summary>
    /// Class to add combo box items and retrieve them more easily
    /// </summary>
    public class ComboBoxItem
    {
        #region "Properties"

        /// <summary>
        /// Text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        public object Value { get; set; }

        #endregion "Properties"

        #region "Methods"

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="text">Text</param>
        /// <param name="value">Value</param>
        public ComboBoxItem(string text, object value)
        {
            this.Text = text;
            this.Value = value;
        }

        /// <summary>
        /// Override to string to display the text entry
        /// </summary>
        /// <returns>Text property</returns>
        public override string ToString()
        {
            return Text;
        }

        #endregion "Methods"
    }
}