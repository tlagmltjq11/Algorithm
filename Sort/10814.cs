using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingTestPractice
{
    public struct Member
    {
        public int age;
        public int order;
        public string name;

        public Member(int age, int order, string name)
        {
            this.age = age;
            this.order = order;
            this.name = name;
        }
    }

    class _10814
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            List<Member> members = new List<Member>();
            string[] data;
            Member member;

            for (int i=0; i<n; i++)
            {
                data = Console.ReadLine().Split(" ");
                member = new Member(int.Parse(data[0]), i, data[1]);
                members.Add(member);
            }

            var result = members.OrderBy(x => x.age).ThenBy(x => x.order);

            foreach(Member m in result)
            {
                sb.AppendLine(m.age.ToString() + " " + m.name);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
