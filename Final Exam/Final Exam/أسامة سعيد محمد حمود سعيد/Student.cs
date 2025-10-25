using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace أسامة_سعيد_محمد_حمود_سعيد
{
    public class Student
    {
        private string name;
        private string part;
        private string level;
        private string imgpath;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetPart(string part)
        {
            this.part = part;
        }

        public void SetLevel(string level)
        {
            this.level = level;
        }

        public void SetImgPath(string imgpath)
        {
            this.imgpath = imgpath;
        }

        public string GetName() => name;

        public string GetPart() => part;

        public string GetLevel() => level;

        public string GetImgPath() => imgpath;



    }
}
