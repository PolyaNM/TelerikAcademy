namespace StudentsByGroupName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public static class ExtensionMethods
    {
        public static Student[] OrderByGroupName(this IEnumerable<Student> listStudents)
        {
            return listStudents.OrderBy(x => x.GroupName).ToArray();
        }
    }
}
