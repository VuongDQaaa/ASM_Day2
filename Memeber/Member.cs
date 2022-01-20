using System;
using ASM_Day2.Enum;

namespace ASM_Day2
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }
        public bool IsGraduated { get; set; }
        public string MemberInfor
        {
            get
            {
                return String.Format("{0} {1} {2}", FirstName, LastName, Gender.ToString());
            }
        }
        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", FirstName, LastName);
            }
        }
    }
}