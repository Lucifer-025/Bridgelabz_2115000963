using System;

class HotelBooking
{
    public string GuestName;
    public string RoomType;
    public int Nights;

    public HotelBooking()
    {
        GuestName = "Unknown";
        RoomType = "Standard";
        Nights = 1;
    }

    public HotelBooking(string guestName, string roomType, int nights)
    {
        GuestName = guestName;
        RoomType = roomType;
        Nights = nights;
    }

    public HotelBooking(HotelBooking hb)
    {
        GuestName = hb.GuestName;
        RoomType = hb.RoomType;
        Nights = hb.Nights;
    }

    public void DisplayBooking()
    {
        Console.WriteLine("Guest" +GuestName);
		Console.WriteLine( "Room"+ RoomType);
		Console.WriteLine( "Nights:"+ Nights);
    }

    static void Main()
    {
        HotelBooking h1 = new HotelBooking();
        HotelBooking h2 = new HotelBooking("John", "Deluxe", 3);
        HotelBooking h3 = new HotelBooking(h2);

        h1.DisplayBooking();
        h2.DisplayBooking();
        h3.DisplayBooking();
    }
}
