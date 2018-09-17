using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCount
{
    public class RoleInfo
    {
        private string _Text;
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }

        private string _Value;
        public string Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        public RoleInfo(string Text, string Value)
        {
            this.Text = Text;
            this.Value = Value;
        }

        public override bool Equals(System.Object obj)
        {
            if (this.GetType().Equals(obj.GetType()))
            {
                RoleInfo that = (RoleInfo)obj;
                return (this.Text.Equals(that.Value));
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.Value.GetHashCode(); ;
        }
    }
}
