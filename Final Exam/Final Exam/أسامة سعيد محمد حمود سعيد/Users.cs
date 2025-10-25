using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace أسامة_سعيد_محمد_حمود_سعيد
{
    public class Users
    {
        private string username;
        private string password;
        private bool IsSelected = false;
        private Student []s=new Student[100];
        private int CountOfStudent = 0;

        public void SetUserName(string username)
        {
            this.username = username;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }

        public void SetIsSelectedOrNot(bool b)
        {
            IsSelected = b;
        }

        public bool getIsSelected() => IsSelected;

        public void SetStudentInformation(string stName, string stPart, string stLevel, string stImgPath)
        {
            s[CountOfStudent] = new Student();
            s[CountOfStudent].SetName(stName);
            s[CountOfStudent].SetPart(stPart);
            s[CountOfStudent].SetLevel(stLevel);
            s[CountOfStudent].SetImgPath(stImgPath);
            CountOfStudent++;
        }

        public Student GetStudentInformation(int i )
        {
            return s[i];
        }

        public string getStudentName(int i) => s[i].GetName();
        public string getStudentPart(int i) => s[i].GetPart();
        public string getStudentLevel(int i) => s[i].GetLevel();
        public string getStudentImg(int i) => s[i].GetImgPath();


        public int getCountOfStudent() => CountOfStudent;
        public string GetUesrName() => username;

        public string GetPassword() => password;
    }
}
