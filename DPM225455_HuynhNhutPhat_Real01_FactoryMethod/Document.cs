﻿using System.Collections.Generic;

namespace DPM225455_HuynhNhutPhat_Real01_FactoryMethod
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();
        // Constructor calls abstract Factory method
        public Document()
        {
            this.CreatePages();
        }
        public List<Page> Pages
        {
            get { return _pages; }
        }
        // Factory Method
        public abstract void CreatePages();
    }
}
