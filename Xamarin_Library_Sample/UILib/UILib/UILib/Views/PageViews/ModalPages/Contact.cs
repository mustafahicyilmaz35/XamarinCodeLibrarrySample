﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinCodeLibrary.Views.PageViews.ModalPages
{
    public class Contact
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Occupation { get; set; }

        public string Country { get; set; }

        public override string ToString()
        {
            return Name;
        }
	}
}
