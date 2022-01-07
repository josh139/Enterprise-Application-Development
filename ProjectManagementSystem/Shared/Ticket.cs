using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Shared
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }

        public Board Board { get; set; }

        [Required]
        public Guid BoardId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public TicketStatus Status { get; set; }

        public TicketPriority Priority { get; set; }

        public DateTime LastUpdated { get; set; }

        public Ticket()
        {
        }

        public Ticket(string name, string description, TicketPriority priority, Guid boardId)
        {
            Name = name;
            Description = description;
            Priority = priority;
            BoardId = boardId;
        }
    }

    public enum TicketStatus
    {
        Todo,
        Started,
        Completed
    }

    public enum TicketPriority
    {
        Crucial,
        High,
        Medium,
        Low
    }
}
