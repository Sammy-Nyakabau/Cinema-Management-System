# :cinema: Cinema Management System :clapper: :movie_camera:
A desktop implementation of a Cinema Management System using [Visual Basic .NET](https://docs.microsoft.com/dotnet/visual-basic/) and [SQL](https://en.wikipedia.org/wiki/SQL).


## :lock: Logging In :key: :unlock:

The file [Login.vb](https://github.com/Sammy-Nyakabau/CinemaSystem/blob/master/Login.vb) contains code that provides access control into the system. Only admins and employees are allowed to enter the system through logging in. The entered credentials are evaluated through querying the data stored in the [users database](https://github.com/Sammy-Nyakabau/CinemaSystem/blob/master/Users.accdb) and comparing it with the entered credentials. Alternately, one can forgo entering credentials by just clicking on the *Visitor* link. This will give them access to a limited version of the system as a visitor. The file [Login.Designer.vb](https://github.com/Sammy-Nyakabau/CinemaSystem/blob/master/Login.Designer.vb) contains the overall design of the Login Form. Below is a screenshot of the Login Form. 

![Login Form](https://i.ibb.co/B4BBwWf/Login-Form.png)

## System Walkthrough :walking: :computer:

### Visitor :coffee:

After clicking the Visitor link, this menu forms comes up giving the user a view on all the movies on show. The user can also choose to view any trailer of his choice as shown. The file [Menu.Visitor.vb](https://github.com/Sammy-Nyakabau/CinemaSystem/blob/master/Menu_Visitor.vb) contains the code the Admin Menu and the file [Menu.Visitor.Designer](https://github.com/Sammy-Nyakabau/CinemaSystem/blob/master/Menu_Visitor.Designer.vb) contains code for the UI design of the dashboard. Below is a screenshot of the **Visitor Menu**.

![Visitor Menu Form](https://i.ibb.co/wJB1zQy/Visitor-Menu-Form.png)

After Clicking the **View Trailer!** Button, the [Trailer Form](https://github.com/Sammy-Nyakabau/CinemaSystem/blob/master/Trailer%201.Designer.vb) comes up and it allows visitors to view trailers of the movies they want to watch. Below is a screenshot of the Trailer Form.

![Trailer Form](https://i.ibb.co/7YmKcGt/Trailer-Form.png)

### Admin Menu :briefcase:

After entering the required parameters and after all verification, the main menu form comes up.
Here the Admin can view all the movies that are on showing and their respective cinemas. The Admin can also book the seats for customers in real time. The file [Menu.Admin.vb](https://github.com/Sammy-Nyakabau/CinemaSystem/blob/master/Menu_Admin.vb) contains the code for the Admin Menu and the file [Menu.Admin.Designer](https://github.com/Sammy-Nyakabau/CinemaSystem/blob/master/Menu_Admin.Designer.vb) contains code for the UI design of the dashboard. Below is a screenshot of the **Admin Menu**.

![Admin Menu Form](https://i.ibb.co/BC2tD8G/Admin-Menu-Form.png)

After clicking the **Book** button. The Booking Form appears. The file [Cinema.vb](https://github.com/Sammy-Nyakabau/CinemaSystem/blob/master/Cinema1.vb) contains the code for the functionality of the Booking Form while the file [Cinema1.Designer.vb](https://github.com/Sammy-Nyakabau/CinemaSystem/blob/master/Cinema1.Designer.vb) contains code for the UI design of the Form.

![Booking Form](https://i.ibb.co/tbqMLCC/Booking-Form.png)

On this form, the Admin can select particular seats for customers. The following screenshots detail the Booking process

1. Selecting Seats and Calculating Change

![Booking 1](https://i.ibb.co/6rMmG8t/Booking-1.png)


2.  Making The Booking. 

![Booking 2](https://i.ibb.co/5YjpfJc/Booking-2.png)

3.  Updated Cinema Form

![Booking 3](https://i.ibb.co/Dfp8vyr/Booking-3.png)

**NB** The selected seats have all now turned from green to red to indicate a booking and the number of booked seats has increased (available seats have decreased)

4. Printing the receipt.

![Booking 4](https://i.ibb.co/K72nHFs/Booking-4.png)

---

The Admin can also view existing bookings from customers by clicking the **View Reservations** Button. The file [ReservedSeats.vb](https://github.com/Sammy-Nyakabau/CinemaSystem/blob/master/ReservedSeats.vb) contains the code that connects with the database [Cinema 1.accdb](https://github.com/Sammy-Nyakabau/CinemaSystem/blob/master/Cinema%201.accdb) to show the existing bookings which are updated everytime a new booking is made.

![Reserved Seats](https://i.ibb.co/LJ6Z8cx/Reserved-Seats.png)

Furthermore, the Admin can also Add New Customers by clicking the **New** button. The file [AddCustomer1.vb](https://github.com/Sammy-Nyakabau/CinemaSystem/blob/master/AddCustomer1.vb) contains the code for connecting with the database and making additions. The file [AddCustomer1.Designer.vb](https://github.com/Sammy-Nyakabau/CinemaSystem/blob/master/AddCustomer1.Designer.vb) contains the overall design of the Add Customer form. 

![Add Customer](https://i.ibb.co/nLqQ3HB/Add-Customer.png)

## Final Notes :bulb: :clipboard:

After the cloning the repository. Open the file [Cinema System.sln](https://github.com/Sammy-Nyakabau/CinemaSystem/blob/master/Cinema%20System.sln) in [Visual Studio](https://visualstudio.microsoft.com/vs/). Make sure that you have [MS Access](https://www.microsoft.com/en-us/microsoft-365/access) running to be able to view and access the database. 
