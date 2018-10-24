## Background
For two years, I worked at the front desk at one of DU's dorms. There were a total of 5 different dorms you could work at, and each dorm had about 25 desk assistants at each dorm. All front desks were open 24/7. Shifts were two hours long during the day (except the 1am-4am and 4am-7am shifts), and typically DA's worked about 10 hours a week.

During my time there, desk assistants were allowed to trade/take shifts with any other desk assistant, as long as you communicated it to the dorm's manager before the time of the shift with who was taking the shift. However, the way the DA's communicated about shifts was *awful*.

The DA's shared a GroupMe text group to post any questions about anything, and also posting shifts that DA's needed to trade or needed someone to take. Because everything was in one thread, it was hard to keep track of all the shifts that needed to be covered, who took what shift, and so on. This resulted in a lot of miscommunication, confusion, and missed shifts. 

## The App

This app is part of a project in my Automating Business Processes class for my business analytics minor. The bounds of the project were loosely defined, just to create a fully functioning app with forms in Visual Basic. Since I have been thinking about making my app for a while, I thought this would be a great opportunity to finally make it. 

For the completion of the project, the user will be able to:
  
  * Log in to their own account created within the app
  * View a list of all the shifts needed to be covered
  * Select a shift and "take" it
      * "take" in this case displays an email draft to the co worker saying that the user is able to take the shift.
  * Be able to view their own shifts that they have posted on the list of open shifts
      * Add, edit, and delete their shifts off the open shift list
  * Log out of the application

For now, all information about the accounts and the shifts are stored via CSV files.

## Future Add ons

After the project is completed, I want to revisit this project and make it more viable. This includes

  * Storing information via a MySQL Database.
      * Encrypting the passwords to the accounts when storing them
  * Actually sending out an email when taking a shift
  * Adding the functionality to see if someone has taken your shift in the app
  * Adding an admin account (used by the desk managers) to see all the shifts open at their dorm
  
