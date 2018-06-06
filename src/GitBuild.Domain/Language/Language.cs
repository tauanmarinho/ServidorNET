namespace GitBuild.Domain.Language
{
    public class Language : Entity
    {
        public string Name {get; private set;}

        public Language (int id, string name)
        {
            ValidateValue(name);
            SetProperties(id, name);
        }

         public void Update (int id, string name)
        {
            ValidateValue(name);
            SetProperties(id, name);
        }

        private void SetProperties(int id, string name)
        {
            Id = id;
            Name = name;
        }

        private static void ValidateValue(string name)
        {
            DomainException.When(string.IsNullOrEmpty(name), "Name is required");
        }

    }
}