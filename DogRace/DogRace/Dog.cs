namespace DogRace
{
    public class Dog
    {
        public Dog(int id, string dogName, string dogType, int dogPoint)
        {
            this.id = id;
            this.dogName = dogName;
            this.dogType = dogType;
            this.dogPoint = dogPoint;
        }

        public int id { set; get; }
        public string dogName { set; get; }
        public string dogType { set; get; }
        public int dogPoint { set; get; }
    }
}
