using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Stamps
{
    internal class GenericStamp : IStamp
    {
        private const string TITLE = "Generic Stamp";
        private const string RENDER = "❔";

        protected string title;
        protected string render;
        protected string color;

        internal GenericStamp()
        {
            this.title = string.Empty;
            this.render = string.Empty;
            this.color = string.Empty;
        }

        internal GenericStamp(string color)
        {
            this.title = GenericStamp.TITLE;
            this.render = GenericStamp.RENDER;
            this.color = color;
        }

        internal GenericStamp(IStamp stamp)
        {
            this.title = GenericStamp.TITLE;
            this.render = GenericStamp.RENDER;
            this.color = stamp.GetColor();
        }

        internal GenericStamp(string title, string render, string color)
        {
            this.title = title;
            this.render = render;
            this.color = color;
        }

        public string GetTitle()
        {
            return this.title ?? string.Empty;
        }

        public string GetRender()
        {
            return this.render ?? string.Empty;
        }

        public string GetColor()
        {
            return this.color ?? string.Empty;
        }

        public virtual IStamp Clone()
        {
            if (this.title == GenericStamp.TITLE && this.render == GenericStamp.RENDER)
            {
                return new GenericStamp(this);
            }
            else
            {
                return new GenericStamp(title: this.title, render: this.render, color: this.color);
            }
        }

        public string GetString()
        {
            return this.title + " - " + this.render + " (" + this.color + ")";
        }
    }
}
