﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quilo3D
{
    public partial class ValidatingTextBox : TextBox
    {

        private string validationPattern;

        public string ValidationPattern
        {
            get { return  validationPattern; }
            set {  validationPattern = value; }
        }

        public bool IsValid { get; private set; }

        public ValidatingTextBox()
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.ValidationPattern = @"^\d+([.,]\d+)?$"; 
            this.BackColor = Color.White;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            IsValid = Regex.IsMatch(this.Text, @"^\d+([.,]\d+)?$");
            this.BackColor = IsValid ? Color.White : Color.LightCoral;
        }
    }
}
