using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Vacations
{
    internal static class VacationDirector
    {
        internal static VacationInvoiceBuilder CoupleWeekendRetreat(VacationInvoiceBuilder builder, DateTime startingDate)
        {
            builder.SetStartingDate(startingDate)
                    .SetEndingDate(startingDate.AddDays(1))
                    .SetHotelDays(2)
                    .SetTotalAmountOfPeople(2)
                    .SetHotelType(VacationInvoice.HotelType.Luxury)
                    .SetFairyWorldDays(2)
                    .AddRegularRestaurantsPass(2)
                    .AddVipTour1Ticket("Firework");

            return builder;
        }

        internal static VacationInvoiceBuilder FamilyWeekendRetreatVIP(VacationInvoiceBuilder builder, DateTime startingDate)
        {
            builder.SetStartingDate(startingDate)
                    .SetEndingDate(startingDate.AddDays(1))
                    .SetHotelDays(2)
                    .SetTotalAmountOfPeople(6)
                    .SetHotelType(VacationInvoice.HotelType.Normal)
                    .AddRegularRestaurantsPass(4)
                    .AddKidsFastPass(4)
                    .AddPhotoshootPass();

            return builder;
        }

        internal static VacationInvoiceBuilder FamilyWeekDeluxe(VacationInvoiceBuilder builder, DateTime startingDate)
        {
            builder.SetStartingDate(startingDate)
                    .SetEndingDate(startingDate.AddDays(6))
                    .SetHotelDays(7)
                    .SetTotalAmountOfPeople(6)
                    .SetHotelType(VacationInvoice.HotelType.Luxury)
                    .AddFineDiningRestaurantsPass(6)
                    .AddAdultFastPass(2)
                    .AddKidsFastPass(4)
                    .AddVipTour1Ticket("VIP Tour")
                    .AddPhotoshootPass();

            return builder;
        }
    }
}
