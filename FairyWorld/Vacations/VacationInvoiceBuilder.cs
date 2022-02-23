using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Vacations
{
    internal class VacationInvoiceBuilder
    {
        private DateTime startingDate;
        private DateTime endingDate;
        private int totalAmountOfPeople;
        private int hotelDays;
        private VacationInvoice.HotelType hotelType;
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

        internal VacationInvoiceBuilder()
        {
            this.Reset();
        }

        internal VacationInvoiceBuilder SetStartingDate(DateTime dt)
        {
            this.startingDate = dt;
            return this;
        }

        internal VacationInvoiceBuilder SetEndingDate(DateTime dt)
        {
            this.endingDate = dt;
            return this;
        }

        internal VacationInvoiceBuilder SetTotalAmountOfPeople(int totalAmountOfPeople)
        {
            this.totalAmountOfPeople = totalAmountOfPeople;
            return this;
        }

        internal VacationInvoiceBuilder SetHotelDays(int hotelDays)
        {
            this.hotelDays = hotelDays;
            return this;
        }

        internal VacationInvoiceBuilder SetHotelType(VacationInvoice.HotelType hotelType)
        {
            this.hotelType = hotelType;
            return this;
        }

        internal VacationInvoiceBuilder SetFairyWorldDays(int fairyWorldDays)
        {
            this.fairyWorldDays = fairyWorldDays;
            return this;
        }

        internal VacationInvoiceBuilder AddAdultFastPass(int adultFastPass)
        {
            this.adultFastPass = adultFastPass;
            return this;
        }

        internal VacationInvoiceBuilder AddKidsFastPass(int kidsFastPass)
        {
            this.kidsFastPass = kidsFastPass;
            return this;
        }

        internal VacationInvoiceBuilder AddArcadePass(int arcadePass)
        {
            this.arcadePass = arcadePass;
            return this;
        }

        internal VacationInvoiceBuilder AddVipTour1Ticket(string vipTour1Ticket)
        {
            this.vipTour1Ticket = vipTour2Ticket;
            return this;
        }

        internal VacationInvoiceBuilder AddVipTour2Ticket(string vipTour2Ticket)
        {
            this.vipTour2Ticket = vipTour2Ticket;
            return this;
        }

        internal VacationInvoiceBuilder AddVipTour3Ticket(string vipTour3Ticket)
        {
            this.vipTour3Ticket = vipTour3Ticket;
            return this;
        }

        internal VacationInvoiceBuilder AddRegularRestaurantsPass(int regularRestaurantsPass)
        {
            this.regularRestaurantsPass = regularRestaurantsPass;
            return this;
        }

        internal VacationInvoiceBuilder AddFineDiningRestaurantsPass(int fineDiningRestaurantsPass)
        {
            this.regularRestaurantsPass = 0;
            this.fineDiningRestaurantsPass = fineDiningRestaurantsPass;
            return this;
        }

        internal VacationInvoiceBuilder AddPhotoshootPass()
        {
            this.hasPhotoshootPass = true;
            return this;
        }

        internal VacationInvoice Build()
        {
            var vi = new VacationInvoice(
                 startingDate: this.startingDate,
                 endingDate: this.endingDate,
                 totalAmountOfPeople: this.totalAmountOfPeople,
                 hotelDays: this.hotelDays,
                 hotelType: this.hotelType,
                 fairyWorldDays: this.fairyWorldDays,
                 adultFastPass: this.adultFastPass,
                 kidsFastPass: this.kidsFastPass,
                 arcadePass: this.arcadePass,
                 vipTour1Ticket: this.vipTour1Ticket,
                 vipTour2Ticket: this.vipTour2Ticket,
                 vipTour3Ticket: this.vipTour3Ticket,
                 regularRestaurantsPass: this.regularRestaurantsPass,
                 fineDiningRestaurantsPass: this.fineDiningRestaurantsPass,
                 hasPhotoshootPass: this.hasPhotoshootPass
                );
            return vi;
        }
        internal void Reset()
        {
            this.startingDate = DateTime.Now;
            this.endingDate = startingDate.AddDays(1);
            this.totalAmountOfPeople = 1;
            this.hotelDays = 2;
            this.hotelType = VacationInvoice.HotelType.Normal;
            this.fairyWorldDays = 2;
            this.adultFastPass = 1;
            this.kidsFastPass = 0;
            this.arcadePass = 0;
            this.vipTour1Ticket = null;
            this.vipTour2Ticket = null;
            this.vipTour3Ticket = null;
            this.regularRestaurantsPass = 1;
            this.fineDiningRestaurantsPass = 0;
            this.hasPhotoshootPass = false;
        }
    }
}
