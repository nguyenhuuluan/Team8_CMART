using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    class ValidationExtension
    {
        public bool Required(string t)
        {
            if (string.IsNullOrEmpty(t) || string.IsNullOrWhiteSpace(t))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool MaxLength(TextBox t, int max)
        {
            if (t.Text.ToString().Length > max)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool checkNumber(string t)
        {
            try {
                double x = double.Parse(t);
                return true;
            }
            catch{
                return false;
            }
        }
        public bool MinLength(TextBox t, int min)
        {
            if (t.Text.ToString().Length < min)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool Compared(TextBox t1, TextBox t2)
        {
            if (t1.Text.Equals(t2.Text))
            { return true; }
            else
            {
                return false;
            }
        }
        public bool Range(TextBox t, double min, double max)
        {
            try
            {
                double x = double.Parse(t.Text);
                if (x >= min && x <= max)
                {
                    return true;
                }
                else
                { return false; }
            }
            catch
            {
                return false;
            }
        }
        public bool EmailOfType(TextBox t)
        {
            Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (r.IsMatch(t.Text))
            { return true; }
            else { return false; }
        }
        public bool PassWordType(TextBox t)
        {
            Regex r = new Regex(@"^([a-zA-Z0-9]{6,15})$");
            if (r.IsMatch(t.Text))
            { return true; }
            else { return false; }
        }


    }
}
