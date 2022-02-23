using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Vacations
{
    internal class VacationInvoice
    {
        private DateTime startingDate;
        private DateTime endingDate;
        private int totalAmountOfPeople;
        private int hotelDays;
        private HotelType hotelType;
        private int fairyWorldDays;
        private int adultFastPass;
        private int kidsFastPass;
        private int arcadePass;
        private string? vipTour1Ticket;
        private string? vipTour2Ticket;
        private string? vipTour3Ticket;
        private int regularRestaurantsPass;
        private int fineDiningRestaurantsPass;
        private bool hasPhotoshootPass;

        internal enum HotelType
        {
            Normal,
            Luxury
        }

        internal VacationInvoice(DateTime startingDate, DateTime endingDate, int totalAmountOfPeople, int hotelDays, HotelType hotelType, int fairyWorldDays, int adultFastPass, int kidsFastPass, int arcadePass, string? vipTour1Ticket, string? vipTour2Ticket, string? vipTour3Ticket, int regularRestaurantsPass, int fineDiningRestaurantsPass, bool hasPhotoshootPass)
        {
            this.startingDate = startingDate;
            this.endingDate = endingDate;
            this.totalAmountOfPeople = totalAmountOfPeople;
            this.hotelDays = hotelDays;
            this.hotelType = hotelType;
            this.fairyWorldDays = fairyWorldDays;
            this.adultFastPass = adultFastPass;
            this.kidsFastPass = kidsFastPass;
            this.arcadePass = arcadePass;
            this.vipTour1Ticket = vipTour1Ticket;
            this.vipTour2Ticket = vipTour2Ticket;
            this.vipTour3Ticket = vipTour3Ticket;
            this.regularRestaurantsPass = regularRestaurantsPass;
            this.fineDiningRestaurantsPass = fineDiningRestaurantsPass;
            this.hasPhotoshootPass = hasPhotoshootPass;
        }

        internal string GetString()
        {
            var sb = new StringBuilder($"Starting Date: {startingDate.ToString("yyyy/MM/dd")}\r\n" +
                $"Ending Date: {endingDate.ToString("yyyy/MM/dd")}\r\n" +
                $"Total amount of people: {totalAmountOfPeople}\r\n" +
                $"Hotel Days: {hotelDays}\r\n" +
                $"Hotel Type: {hotelType.ToString()}\r\n" +
                $"FairyWorld days: {fairyWorldDays}\r\n" +
                $"Adult Fast pass: {adultFastPass}\r\n" +
                $"Kids Fast Pass: {kidsFastPass}\r\n" +
                $"Arcade Pass: {arcadePass}\r\n");

            if (!string.IsNullOrEmpty(vipTour1Ticket))
            {
                sb.Append($"VIP Tour 1: {vipTour1Ticket}\r\n");
            }

            if (!string.IsNullOrEmpty(vipTour2Ticket))
            {
                sb.Append($"VIP Tour 2: {vipTour2Ticket}\r\n");
            }

            if (!string.IsNullOrEmpty(vipTour3Ticket))
            {
                sb.Append($"VIP Tour 3: {vipTour3Ticket}\r\n");
            }

            if (this.regularRestaurantsPass > 0)
            {
                sb.Append($"Breakfast/Lunch/Dinner Regular Restaurants: {regularRestaurantsPass}\r\n");
            }
            else
            {
                sb.Append($"Breakfast/Lunch/Dinner Fine Dining Restaurants: {fineDiningRestaurantsPass}\r\n");
            }

            if (this.hasPhotoshootPass)
            {
                sb.Append($"with Photoshoot");
            }
            
            return sb.ToString();
        }
    }
}
