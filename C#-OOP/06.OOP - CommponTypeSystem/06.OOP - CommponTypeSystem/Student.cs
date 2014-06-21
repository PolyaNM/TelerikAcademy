using System;
using System.Text;

class Student : ICloneable, IComparable<Student>
{
    private string firstName;
    private string middleName;
    private string lastName;
    private uint ssn;
    private string address;
    private string mobilePhone;
    private string email;
    private string course;
    private Specialty specialty;
    private Faculty faculty;
    private University university;

    public Student(string fName, string mName, string lName, uint ssn, string address, string mPhone, string email, string course, Specialty specialty, Faculty faculty, University university)
    {
        this.FirstName = fName;
        this.MiddleName = mName;
        this.LastName = lName;
        this.SSN = ssn;
        this.Address = address;    
        this.MobilePhone = mPhone;
        this.Email = email;
        this.Course = course;
        this.Specialty = specialty;
        this.Faculty = faculty;
        this.University = university;
    }

    public string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("First name cannot be null or empty!");
            }
            firstName = value;
        }
    }

    public string MiddleName
    {
        get
        {
            return middleName;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Middle name cannot be null or empty!");
            }
            middleName = value;
        }
    }

    public string LastName
    {
        get
        {
            return lastName;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Last name cannot be null or empty!");
            }
            lastName = value;
        }
    }

    public uint SSN
    {
        get
        {
            return ssn;
        }
        set
        {
            ssn = value;
        }
    }

    public string Address
    {
        get
        {
            return address;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Address cannot be null or empty!");
            }
            address = value;
        }
    }

    public string MobilePhone
    {
        get
        {
            return this.mobilePhone;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Phone cannot be null or empty!");
            }
            this.mobilePhone = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Email cannot be null or empty!");
            }
            this.email = value;
        }
    }

    public string Course
    {
        get
        {
            return this.course;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Course can not be null or empty!");
            }
            this.course = value;
        }
    }

    public Specialty Specialty
    {
        get
        {
            return this.specialty;
        }
        set
        {
            //if (value == null)
            //{
            //    throw new ArgumentException("Speciality can not be null!");
            //}
            this.specialty = value;
        }
    }

    public Faculty Faculty
    {
        get
        {
            return this.faculty;
        }
        set
        {
            //if (value == null)
            //{
            //    throw new ArgumentException("Faculty can not be null!");
            //}
            this.faculty = value;
        }
    }

    public University University
    {
        get
        {
            return this.university;
        }
        set
        {
            //if (value == null)
            //{
            //    throw new ArgumentException("University can not be null!");
            //}
            this.university = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        var properties = this.GetType().GetProperties();

        foreach (var prop in properties)
        {
            sb.AppendFormat("{0} - {1}", prop.Name, prop.GetValue(this));
            sb.AppendLine();
        }

        return sb.ToString();
    }

    public override bool Equals(object obj)
    {
        var student = obj as Student;

        if (student == null)
        {
            throw new ArgumentException("The input object is not of type Student");
        }

        if (!Object.Equals(this.FirstName, student.FirstName))
        {
            return false;
        }

        if (!Object.Equals(this.SSN, student.SSN))
        {
            return false;
        }

        return true; 
    }

    public static bool operator ==(Student student1, Student student2)
    {
        return Student.Equals(student1, student2);
    }

    public static bool operator !=(Student student1, Student student2)
    {
        return !Student.Equals(student1, student2);
    }

    public override int GetHashCode()
    {
        return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.SSN.GetHashCode();
    }

    public Student Clone()
    {
        Student result = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address,
            this.MobilePhone, this.Email, this.Course, this.Specialty, this.Faculty, this.University);

        return result;
    }
    Object ICloneable.Clone()
    {
        return this.Clone();
    }
    public int CompareTo(Student other)
    {
        if (this.FirstName != other.FirstName)
        {
            return this.FirstName.CompareTo(other.FirstName);
        }
        if (this.MiddleName != other.MiddleName)
        {
            return this.MiddleName.CompareTo(other.MiddleName);
        }
        if (this.LastName != other.LastName)
        {
            return this.LastName.CompareTo(other.LastName);
        }
        if (this.SSN != other.SSN)
        {
            return this.SSN.CompareTo(other.SSN);
        }
        return 0;
    }
}
