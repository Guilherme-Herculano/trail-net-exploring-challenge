# DIO - .NET Track - Exploring the C# Language
www.dio.me

## Project Challenge
For this challenge, you will need to apply the knowledge you've gained in the "Exploring the C# Language" module of the .NET track at DIO.

## Context
You have been hired to build a hotel booking system, which will be used to make reservations at a hotel. You will need to use the Person class, which represents the guest, the Suite class, and the Reservation class, which will establish a relationship between them.

Your program should correctly calculate the values of the methods in the Reservation class, which should provide the number of guests and the daily rate, offering a 10% discount if the reservation is for a period longer than 10 days.

## Rules and Validations
1. It should not be possible to make a reservation for a suite with a capacity less than the number of guests. For example, if it's a suite that can accommodate 2 people, attempting to reserve with 3 guests should throw an exception.

2. The GetNumberOfGuests method in the Reservation class should return the total number of guests, while the CalculateDailyRate method should return the daily rate (Reserved days x daily rate).

3. If a reservation is made for 10 days or more, a 10% discount should be granted on the daily rate.


![Hotel class diagram](diagrama_classe_hotel.png)

## Solution
The code is halfway done, and you should continue by following the rules described above, so that in the end, we have a functional program. Look for the word "TODO" commented in the code, and then implement it according to the rules mentioned above.
