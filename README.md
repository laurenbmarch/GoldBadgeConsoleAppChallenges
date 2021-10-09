![headerphoto](gb-challenge-header-for-readme.png)
# :1st_place_medal: Gold Badge Console Application Challenges 

The Gold Badge Challenges are projects designed by Eleven Fifty Academy to evaluate a student's progress in the Software Development program. There are 8 challenges available, I have chosen three to complete and showcase. The challenges were completed in C# using Visual Studio Community. Each challenge is contained in a single Solution.

I have completed the following challenges:

* Challenge 1: Komodo Cafe
* Challenge 3: Komodo Insurance Badges
* Challenge 4: Komodo Company Outings
 

## :coffee: Challenge One: The Komodo Cafe
This challenge for the "Komodo Cafe" involved creating an application that allowed the manager to create new menu items, delete menu items, and receive a list of all of the item's on the cafe's menu. Each menu item had asigned properties including a meal name and number, a description of the item, a list of ingredients, and the sale price.

By creating a "Menu Item" object, I assigned it properties and made badic CRUD operations in the "Menu Item" Repository. In the UI, the user is able to choose a selection from a menu to create, delete, and view menu items.

## :police_officer: Challenge Three: Komodo Insurance Badges
This challenge for "Komodo Insurance" involved creating an application for their Security Admin to maintain details about employee badge information. The Admin needed to be able to create a new employee badge, update the doors to which it has access, and see a list of all company badges and their coorresponding doors of access. 

I first created a "Badge" object and assigned it properties: Id number, the employee to whom it belonged, and a list of door names to which it had access. By creating a dictionary collection type, I was able to store each badge "element", with the badge ID number as the key and the badge object as the value. In the UI, the Admin is able to choose a menu option to add a new badge, edit an existing badge (which includes options to either add or remove access to a door), and see the whole collection of badges and their cooresponding doors of access.

## :ferris wheel: Challenge Four: Komodo Company Outings
This challenge involved creating an application for "Komodo" as a way to view and manage the spending on company outings. The company needed to view a list of all of the company outings, the cost of all of the outings together, as well as the costs of the outings by type (golf, bowling, amusement park, or concert).

I created an "Outing" object and assigned it properties of event type, number of people that attended, date of the event, total cost per person for the event, and total cost of the event. I had the program set the total cost of the event equal to the number of people attending multiplied by the cost of the event per person, but, if needed, this could be adjusted in case there were additional costs that would contribute to the toal cost of the event.

In the UI, the user is able to choose a selection from a menu to view all of the outings, add a new outing, and calculate costs by outing type or by all outings combined.

## :bulb: What Did I Learn?
This project allowed multiple areas of growth for me, especially with the following:
* **Dictionaries** - I didn't have much experience before this project in creating and utilizing a dictionary collection type in a project. This was a great opportunity for me to research and learn more about this collection type. I now know a lot more about dictionaries and how they can be very useful.
* **Unit Testing** - This was another area where I had very little experience and was excited to learn more. I learned how to test different methods and learned how useful testing can be especially as your project grows in size.
* **Repository Pattern** - Practice makes perfect! These three challenges gave me more exposure to creating class objects and repositories and I can say that I am more confident in creating these types of applications after completing this project.

## :smiley: What's Next?
I would like to expand on each of these projects, especially the first challenge with the "Komodo Cafe". I would like to add functionlity to list items by potential allergen type (ex: gluten, dairy, etc.) to assist the manager in recommending certain meals to a customer with an allergy. I also would like to add a function to the "Komodo Outing" Application to view the list of outings by year and to view the total costs by year. 

I would also like to embark on the other 5 challenges to see how much progress I have made in my coding skills. Stay tuned for more in the future!


### :computer: Eleven Fifty Academy
I would not be this far along in my coding journey without Elven Fifty Academy. To learn more about thim click here: [Eleven Fifty Academy](https://elevenfifty.org/).
