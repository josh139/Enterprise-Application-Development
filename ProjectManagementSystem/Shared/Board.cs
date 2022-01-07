using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Shared
{
    public class Board
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        //Navigation Properties

        [Required]
        public Guid CompanyId { get; set; }

        [ValidateComplexType]
        public Company Company { get; set; }

        public List<Ticket> Tickets { get; set; }

        public Board()
        {
        }

        public Board(string name, string description, Guid companyId)
        {
            Name = name;
            Description = description;
            CompanyId = companyId;
            Tickets = new List<Ticket>();
        }
    }
}
