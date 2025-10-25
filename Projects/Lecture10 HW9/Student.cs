using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10_HW9
{
    public class Student
    {
        private int number;
        private string name;
        private string birthdate;
        private string imgpath;

        public void SetNumber(int number)
        {
            this.number = number;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetBirthDate(string birthdate)
        {
            this.birthdate = birthdate;
        }

        public void SetImgPath(string imgpath)
        {
            this.imgpath = imgpath;
        }

        public int GetNumber() => number;
        public string GetName() => name;
        public string GetBirthDate() => birthdate;
        public string GetImgPath() => imgpath;
    }
}
