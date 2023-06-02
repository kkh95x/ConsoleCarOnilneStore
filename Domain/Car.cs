namespace Domain
{
    public class Car
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public DateTime Year { get; set; }
        public string? Gear { get; set; }
        public double Km { get; set; }

        //M -> N RS
        public List<Part> Parts { get; set; }

    }
}