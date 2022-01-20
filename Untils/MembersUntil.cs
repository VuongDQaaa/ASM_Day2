using System;
using System.Collections.Generic;
using System.Linq;
using ASM_Day2.Enum;
namespace ASM_Day2.Untils
{
    public class MembersUntil
    {
        private List<Member> _members;
        public MembersUntil()
        {
            _members = InitMembers();
        }
        public List<Member> GetAllMember()
        {
            return _members;
        }
        public List<Member> GetMaleMembers()
        {
            IEnumerable<Member> linq = from member in _members
                                       where member.Gender == Gender.Male
                                       select member;
            List<Member> result = linq.ToList();
            return result;
        }
        public Member GetOldestMember()
        {
            Member result = _members.OrderByDescending(member => member.Age).FirstOrDefault();
            return result;
        }
        public List<string> GetFullNames()
        {
            IEnumerable<string> linq = from member in _members
                                       select member.FullName;
            List<string> result = linq.ToList();
            return result;
        }
        public List<Member> GetLessThan2000()
        {
            IEnumerable<Member> linq = from member in _members
                                       where member.DateOfBirth.Year < 2000
                                       select member;
            List<Member> result = linq.ToList();
            return result;
        }
        public List<Member> GetEqual2000()
        {
            IEnumerable<Member> linq = from member in _members
                                       where member.DateOfBirth.Year == 2000
                                       select member;
            List<Member> result = linq.ToList();
            return result;
        }
        public List<Member> GetGreaterThan2000()
        {
            // IEnumerable<Member> linq = from member in _members
            //                            where member.DateOfBirth.Year > 2000
            //                            select member;
            var linq = _members.FindAll(member => member.DateOfBirth.Year>2000);
            // Console.WriteLine(_members[3].DateOfBirth.Year);
            List<Member> result = linq.ToList();
            return result;
        }
        public Member GetFirstBornInHanoi()
        {
            Member result = _members.Find(member => member.BirthPlace == "Ha Noi");
            return result;
        }
        public void PrintMember(Member member)
        {
            Console.WriteLine(member.MemberInfor);
        }
        public void PrintMembersList(List<Member> members)
        {
            foreach (Member member in members)
            {
                PrintMember(member);
            }
        }
        public void PrintMembersList(List<string> members)
        {
            foreach (var memberName in members)
            {
                Console.WriteLine(memberName);
            }
        }
        private List<Member> InitMembers()
        {
            return new List<Member>
            {
                new Member(){
                    FirstName = "Dao",
                    LastName = "Vuong1",
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(2000,3,29),
                    BirthPlace = "Ha Noi",
                    IsGraduated = false,
                },
                new Member(){
                    FirstName = "Dao",
                    LastName = "Vuong2",
                    Gender = Gender.Female,
                    DateOfBirth = new DateTime(1999,3,29),
                    BirthPlace = "Lao Cai",
                    IsGraduated = false,
                },
                new Member(){
                    FirstName ="Dao",
                    LastName = "Vuong3",
                    Gender = Gender.Other,
                    BirthPlace ="Lao Cai",
                    DateOfBirth = new DateTime(1998,2,12),
                },
                new Member(){
                    FirstName = "Dao",
                    LastName = "Vuong4",
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(2001,3,29),
                    BirthPlace = "Ha Noi",
                    IsGraduated = false,
                },
            };
        }
    }
}