using TaskProject.Validations;

namespace TaskProject.Models
{
    public class TestModel
    {
        public int Id { get; set; }

        [EvenNumber]
        public int MyNumber { get; set; }
    }
}
