
using GuestBookDemo;

GuestLogic.WelcomeMessage();

(List<string> guests, int totalGuests) =  GuestLogic.GetAllGuests();

GuestLogic.DisplayGuests(guests);
GuestLogic.DisplayGuestCount(totalGuests);