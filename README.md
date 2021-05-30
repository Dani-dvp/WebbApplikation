"# ResturantReview" 

What is this?

Its a fullstack webapplication that uses EF core as a backend with a website written in react as a front end.
The idea of the website is a place where you can review restaurants and see other peoples reviews.

Prereq:
Node.js

For Cors problems in developer mode install:
https://chrome.google.com/webstore/detail/moesif-origin-cors-change/digfbfaphojjndkpccljibejjbppifbc/related?hl=en-US

Top right turn it on.

How to install:

1. Set startup to RestaurantRewiew.Api

2. Write following commands in powershell:

  2.1 set default project in powershell to RestaurantReview.Authentication
  2.2 add-migration NameOfMigration -context AuthenticationDbContext
  2.3 update-database -context AuthenticationDbContext
  
  2.4 change default project to RestaurantReview.Infrastructure
  2.5 add-migration NameOfMigration -context MyDbContext
  2.6 update-database -context MyDbContext
  
3. Set multiple startups to RestaurantReview.Api and RestaurantReview.UI

4. Start the program

How to use:
Use swagger and seed the database using "Create seed".

Use this account for login: test@example.com and "Password123!"

Then navigate to the website and test it out!


