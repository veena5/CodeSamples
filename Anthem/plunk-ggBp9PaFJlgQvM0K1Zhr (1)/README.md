#CODING EXERCISE - JavaScript/SPA

##Evaluation Guidelines 

Using this plunker project as seed, Build a Temperature Monitor Single Page Application (SPA) using Angular and test your the aplication code using Jasmine.

**User Story #1**
As an anonymous end user, I want to be able to enter any number of temperture records by entering a value and then clicking on the "Add" button.

**User Story #2**
As an anonymous end user,  When I click on the "Get Media Temperture" button, I want to be able to see the median of the entered tempertures records that I have entered.

**Technical Tasks**
- For user story #1 and #2. Create a javascript object named "TemperatureMonitor". 
- This object MUST have a method named "recordTemperature" that will accept a number value.
- This object MUST have a method called "getCurrentMedian" that will return the median of the recorded values.

Use this TemperatureMonitor object in the Angular SPA.

- The Code that calculates the median MUST be your own (no libraries allowed)
- The Code that calculates the median MUST be covered by Unit Tests (As much as you feel necessary to ensure good code quality)

##Unit Test Sample Data
`// [5, 1, -7, 7, 8, 3] --> [-7, 1, 3, 5, 7, 8] = (3+5)/2 = 4`
`// [5, 1, -7, 7, 8, 3, 9] --> [-7, 1, 3, 5, 7, 8, 9] = 5`


##Instructions

- **Fork** this Plunker Project
- Code
- Make sure to unit test your code
- Save and Send us the link to this Plunker


Jasmine documentation can be found at http://jasmine.github.io/2.0/introduction.html

You can find a definition of what is a Median at http://en.wikipedia.org/wiki/Median


