using System.ComponentModel.DataAnnotations;
using WebStocks.Models.ValidationAttributes;

namespace WebStocks.Models
{
    public class AddStockViewModel 
    {
        [Required]
        [MinLength(2, ErrorMessage = "������� �������� ��������, �� ����")]       
        public string Name { get; set; }

        [CheckingForPositiveNumbers]
        public int Price { get; set; }
    }
}
