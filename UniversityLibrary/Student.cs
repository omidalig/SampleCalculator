namespace UniversityLibrary
{
    public class Student:Human
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public new int Age { get; set; }
        public override string Parent { get => base.Parent; set => base.Parent = value; }
        public override bool IsMale { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string GetFullName() {
            
            return $"{FirstName} - {LastName}";
        }

    }
}