using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial2
{
    [Serializable]
    internal class Sistema
    {
        private List<Transporte> transportes;
        private List<Ticket> tickets;
        public Sistema()
        {
            transportes = new List<Transporte>();
            tickets = new List<Ticket>();
        }
        public List<Ticket> Tickets => tickets;
        public int CantTransportes => transportes.Count;
        public int CantTickets => tickets.Count;
        public void AgregarTransporte(Transporte unTransporte)
        {
            transportes.Add(unTransporte);
        }
        public void AgregarTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }
        public Ticket VerTicket(int i)
        {
            return tickets[i];
        }
        public Transporte VerTransporte(int i)
        {
            return transportes[i];
        }
    }
}
