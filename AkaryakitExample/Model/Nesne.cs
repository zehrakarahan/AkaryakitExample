namespace AkaryakitExample.Model
{
    public class Nesne
    {
        public string id;
        public string name;
        public Nesne(string id)
        {

            this.id = id;

        }
        public Nesne(string id,string name)
        {
            this.id=id;
            this.name = name;

        }
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
