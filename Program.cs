using System;
using ASM_Day2.Untils;
namespace ASM_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            MembersUntil membersUntil = new MembersUntil();
            Console.WriteLine("Cau 1:-----------------------------------");
            membersUntil.PrintMembersList(membersUntil.GetMaleMembers());
            Console.WriteLine("Cau 2:-----------------------------------");
            membersUntil.PrintMember(membersUntil.GetOldestMember());
            Console.WriteLine("Cau 3:-----------------------------------");
            membersUntil.PrintMembersList(membersUntil.GetFullNames());
            Console.WriteLine("Cau 4:-----------------------------------");
            Console.WriteLine("Greater 2000:-----------------------------------");
            membersUntil.PrintMembersList(membersUntil.GetGreaterThan2000());
            Console.WriteLine("Equal 2000:-----------------------------------");
            membersUntil.PrintMembersList(membersUntil.GetEqual2000());
            Console.WriteLine("Less 2000:-----------------------------------");
            membersUntil.PrintMembersList(membersUntil.GetLessThan2000());
            Console.WriteLine("Cau 5:-----------------------------------");
            membersUntil.PrintMember(membersUntil.GetFirstBornInHanoi());

        }
    }
};
